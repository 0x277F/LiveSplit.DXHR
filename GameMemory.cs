using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.DXHR
{
    class GameMemory
    {
        public enum SplitArea : int
        {
            None,
            Prologue,
            Sarif,
            Detroit1,
            FEMA,
            Hengsha1,
            TaiYong1,
            TaiYong2,
            Picus,
            Detroit2,
            Hengsha2,
            Singapore,
            Panchaea,
        }

        public event EventHandler OnFirstLevelLoading;
        public event EventHandler OnPlayerGainedControl;
        public event EventHandler OnLoadStarted;
        public event EventHandler OnLoadFinished;
        public delegate void SplitCompletedEventHandler(object sender, SplitArea type, uint frame);
        public event SplitCompletedEventHandler OnSplitCompleted;

        private Task _thread;
        private CancellationTokenSource _cancelSource;
        private SynchronizationContext _uiThread;
        private List<int> _ignorePIDs;
        private DXHRSettings _settings;

        private DeepPointer _isLoadingPtr;
        // private DeepPointer _isLoadingPtr2;
        private DeepPointer _streamGroupIdPtr;
        private DeepPointer _cutsceneIdPtr;
        // private DeepPointer _inGameTimePtr;

        private static class StreamGroup
        {
            public const string Prologue = "det_sarifhq_rail_tutorial";
            public const string Sarif = "det_sarif_industries";
            public const string SarifPlant = "det_sam_ext_warehouse";
            public const string SarifPlantAssembly = "det_sam_assembly";
            public const string SarifPlantRestricted = "det_sam_restrictedarea";
            public const string SarifPlantAdmin = "det_sam_administration";
            public const string DetroitSarif = "det_city_sarif";
            public const string DetroitLIMB = "det_city_limb_clinic";
            public const string DetroitTunnel = "det_city_tunnel1";
            public const string DetroitPolice = "det_city_police";
            public const string PoliceStation = "det_police";
            public const string DetroitTransIndustrial = "det_city_transindustrial";
            public const string DetroitIndustrial = "det_city_industrial";
            public const string DetroitRiot1 = "det_city_back1";
            public const string DetroitRiot2 = "det_city_back2";
            public const string AdamAptLower = "det_adam_apt_a";
            public const string AdamAptMid = "det_adam_apt_b";
            public const string AdamAptUpper = "det_adam_apt_c";
            public const string FEMA = "det_fema_exterior";
            public const string FEMABossfight = "det_fema_bossroom";
            public const string HengshaNightlife = "sha_city_lowernightlife";
            public const string HengshaWorker = "sha_city_lowerworker";
            public const string HengshaResidential = "sha_city_lowerresidential";
            public const string HengshaSewer = "sha_city_sewer1a";
            public const string HengshaHarvester = "sha_city_lowerharvester";
            public const string HengshaPort = "sha_city_port_2a";
            public const string TaiYong = "sha_tym_pool_room";
            public const string TaiYongLower = "sha_tym_elevator_lower_a";
            public const string TaiYongAssembly = "sha_tym_assembly_line";
            public const string TaiYongElevator = "sha_tym_elevator_floof_a";
            public const string TaiYongAdmin = "sha_tym_lab_admin";
            public const string TaiYongUpper = "sha_tym_elevator_upper_a";
            public const string TaiYongPenthouse = "sha_tym_penthouse";
            public const string PicusHelipad = "pic_helipad";
            public const string PicusElizase = "pic_elizase";
            public const string PicusRestricted = "pic_restricted_area";
            public const string PicusBossfight = "pic_bossfight";
            public const string RIPMalik = "sha_city_constructionsite_2a";
            public const string Singapore = "sin_omega_exterior";
            public const string SingaporeRestricted = "sin_omega_restricted_area";
            public const string Panchaea = "pan_insertion";
            public const string PanchaeaHanger = "pan_hanger";
            public const string PanchaeaRing = "pan_ring";
            public const string PanchaeaBridge = "pan_starwars_bridge";
            public const string PanchaeaBossfight = "pan_elevator_hyronproject";
            public const string PanchaeaEnd = "pan_hyronproject";
        }

        private enum Cutscenes
        {
            PrologueEnd = 976896,
            Sarif1Start = 595968,
            Sarif1End = 600064,
            SarifPlantStart = 739328,
            SarifPlantSanders = 724992,
            Sarif2Sarif = 727040,
            Detroit1LIMB = 667648,
            Detroit1AdamApt = 724992,
            FEMAWindow = 727040,
            FEMABoss = 724992,
            FEMABossDead = 786432,
            HengshaStart = 1011712,
            TaiYongPenthouse = 724992,
            PicusStart = 727040,
            PicusBoss = 724992,
            PicusBossDead = 729088,
            Detroit2Start = 1107968,
            Detroit2Darrow = 724992,
            RIPMalik = 821248,
            HengshaTong = 845824,
            HengshaBomb = 735232,
            SingaporeStart = 735232,
            SingaporeBoss = 774144,
            SingaporeBossDead = 727040,
            SingaporeMegan = 874496,
            SingaporeEnd = 833536,
            PanchaeaBoss = 747520,
            PanchaeaBossDead = 983040,
            EndingDarrow = 1908736,
            EndingSarif = 1699840,
            EndingTaggart = 1810432,
            EndingSuicide = 1832960,
        }

        private enum ExpectedDllSizes
        {
            DXHRSteam = 29642752,
            DXHRDCSteam = 1337,
            DXHRCracked = 0451,
        }

        public bool[] splitStates { get; set; }

        public void resetSplitStates()
        {
            for (int i = 0; i <= (int)SplitArea.Panchaea; i++)
            {
                splitStates[i] = false;
            }
        }

        public GameMemory(DXHRSettings componentSettings)
        {
            _settings = componentSettings;
            splitStates = new bool[(int)SplitArea.Panchaea + 1];

            _isLoadingPtr = new DeepPointer(0x1876708); // == 1 if a loadscreen is happening
            // _isLoadingPtr2 = new DeepPointer(0x1855800); // == 1 if a loadscreen is happening
            // _streamGroupIdPtr = new DeepPointer(0x1838D30); // ID of the current stream group
            _streamGroupIdPtr = new DeepPointer(0x1857924); // ID of the current stream group
            _cutsceneIdPtr = new DeepPointer(0x1ACE2C0); // ID of the current cutscene
            // _inGameTimePtr = new DeepPointer(0x9E7744); // In-game time in seconds

            resetSplitStates();

            _ignorePIDs = new List<int>();
        }

        public void StartMonitoring()
        {
            if (_thread != null && _thread.Status == TaskStatus.Running)
            {
                throw new InvalidOperationException();
            }
            if (!(SynchronizationContext.Current is WindowsFormsSynchronizationContext))
            {
                throw new InvalidOperationException("SynchronizationContext.Current is not a UI thread.");
            }

            _uiThread = SynchronizationContext.Current;
            _cancelSource = new CancellationTokenSource();
            _thread = Task.Factory.StartNew(MemoryReadThread);
        }

        public void Stop()
        {
            if (_cancelSource == null || _thread == null || _thread.Status != TaskStatus.Running)
            {
                return;
            }

            _cancelSource.Cancel();
            _thread.Wait();
        }

        void MemoryReadThread()
        {
            Debug.WriteLine("[NoLoads] MemoryReadThread");

            while (!_cancelSource.IsCancellationRequested)
            {
                try
                {
                    Debug.WriteLine("[NoLoads] Waiting for dxhr.exe...");

                    Process game;
                    while ((game = GetGameProcess()) == null)
                    {
                        Thread.Sleep(250);
                        if (_cancelSource.IsCancellationRequested)
                        {
                            return;
                        }
                    }

                    Debug.WriteLine("[NoLoads] Got dxhr.exe!");

                    uint frameCounter = 0;

                    bool prevIsLoading = false;
                    string prevStreamGroupId = String.Empty;
                    int prevCutsceneId = 0;

                    bool loadingStarted = false;

                    while (!game.HasExited)
                    {
                        string streamGroupId = String.Empty;
                        _streamGroupIdPtr.Deref(game, out streamGroupId, 55);

                        bool isLoading;
                        _isLoadingPtr.Deref(game, out isLoading);

                        int cutsceneId;
                        _cutsceneIdPtr.Deref(game, out cutsceneId);

                        if (streamGroupId != prevStreamGroupId)
                        {
                            if (prevStreamGroupId == StreamGroup.Prologue && streamGroupId == StreamGroup.Sarif)
                            {
                                Split(SplitArea.Prologue, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.SarifPlantAdmin && streamGroupId == StreamGroup.Sarif)
                            {
                                Split(SplitArea.Sarif, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.DetroitIndustrial && streamGroupId == StreamGroup.FEMA)
                            {
                                Split(SplitArea.Detroit1, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.FEMA && streamGroupId == StreamGroup.Sarif)
                            {
                                Split(SplitArea.FEMA, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.HengshaNightlife && streamGroupId == StreamGroup.TaiYong)
                            {
                                Split(SplitArea.Hengsha1, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.TaiYongAssembly && streamGroupId == StreamGroup.TaiYongElevator)
                            {
                                Split(SplitArea.TaiYong1, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.TaiYongPenthouse && streamGroupId == StreamGroup.PicusHelipad)
                            {
                                Split(SplitArea.TaiYong2, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.PicusRestricted && streamGroupId == StreamGroup.AdamAptUpper)
                            {
                                Split(SplitArea.Picus, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.Sarif && streamGroupId == StreamGroup.RIPMalik)
                            {
                                Split(SplitArea.Detroit2, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.HengshaPort && streamGroupId == StreamGroup.Singapore)
                            {
                                Split(SplitArea.Hengsha2, frameCounter);
                            }
                            else if (prevStreamGroupId == StreamGroup.SingaporeRestricted && streamGroupId == StreamGroup.Panchaea)
                            {
                                Split(SplitArea.Singapore, frameCounter);
                            }
                        }

                        if (isLoading != prevIsLoading)
                        {
                            if (isLoading)
                            {
                                Debug.WriteLine(String.Format("[NoLoads] Load Start - {0}", frameCounter));

                                loadingStarted = true;

                                // pause game timer
                                _uiThread.Post(d =>
                                {
                                    if (this.OnLoadStarted != null)
                                    {
                                        this.OnLoadStarted(this, EventArgs.Empty);
                                    }
                                }, null);

                                if (streamGroupId == StreamGroup.Prologue)
                                {
                                    // reset game timer
                                    _uiThread.Post(d =>
                                    {
                                        if (this.OnFirstLevelLoading != null)
                                        {
                                            this.OnFirstLevelLoading(this, EventArgs.Empty);
                                        }
                                    }, null);
                                }
                            }
                            else
                            {
                                Debug.WriteLine(String.Format("[NoLoads] Load End - {0}", frameCounter));

                                if (loadingStarted)
                                {
                                    loadingStarted = false;

                                    // unpause game timer
                                    _uiThread.Post(d =>
                                    {
                                        if (this.OnLoadFinished != null)
                                        {
                                            this.OnLoadFinished(this, EventArgs.Empty);
                                        }
                                    }, null);

                                    if (streamGroupId == StreamGroup.Prologue)
                                    {
                                        // start game timer
                                        _uiThread.Post(d =>
                                        {
                                            if (this.OnPlayerGainedControl != null)
                                            {
                                                this.OnPlayerGainedControl(this, EventArgs.Empty);
                                            }
                                        }, null);
                                    }
                                }
                            }
                        }

                        if (cutsceneId != prevCutsceneId)
                        {
                            if (cutsceneId == (int)Cutscenes.EndingDarrow || cutsceneId == (int)Cutscenes.EndingSarif || cutsceneId == (int)Cutscenes.EndingTaggart || cutsceneId == (int)Cutscenes.EndingSuicide)
                            {
                                Split(SplitArea.Panchaea, frameCounter);
                            }
                        }

                        Debug.WriteLineIf(streamGroupId != prevStreamGroupId, String.Format("[NoLoads] streamGroupId changed from {0} to {1} - {2}", prevStreamGroupId, streamGroupId, frameCounter));
                        Debug.WriteLineIf(cutsceneId != prevCutsceneId, String.Format("[NoLoads] cutsceneId changed from {0} to {1} - {2}", prevCutsceneId, cutsceneId, frameCounter));

                        prevStreamGroupId = streamGroupId;
                        prevIsLoading = isLoading;
                        prevCutsceneId = cutsceneId;
                        frameCounter++;

                        Thread.Sleep(15);

                        if (_cancelSource.IsCancellationRequested)
                        {
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Thread.Sleep(1000);
                }
            }
        }

        private void Split(SplitArea split, uint frame)
        {
            Debug.WriteLine(String.Format("[NoLoads] split {0} - {1}", split, frame));
            _uiThread.Post(d =>
            {
                if (this.OnSplitCompleted != null)
                {
                    this.OnSplitCompleted(this, split, frame);
                }
            }, null);
        }

        Process GetGameProcess()
        {
            Process game = Process.GetProcesses().FirstOrDefault(p => p.ProcessName.ToLower() == "dxhr"
                && !p.HasExited && !_ignorePIDs.Contains(p.Id));
            if (game == null)
            {
                return null;
            }

            if (game.MainModule.ModuleMemorySize != (int)ExpectedDllSizes.DXHRSteam && game.MainModule.ModuleMemorySize != (int)ExpectedDllSizes.DXHRCracked)
            {
                _ignorePIDs.Add(game.Id);
                _uiThread.Send(d => MessageBox.Show("Unexpected game version. DXHR 1.4.651.0 is required.", "LiveSplit.DXHR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error), null);
                return null;
            }

            return game;
        }
    }
}
