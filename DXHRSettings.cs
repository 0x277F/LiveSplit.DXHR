using System;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.DXHR
{
    public partial class DXHRSettings : UserControl
    {
        public bool AutoReset { get; set; }
        public bool AutoStart { get; set; }
        public bool Prologue { get; set; }
        public bool Sarif { get; set; }
        public bool Detroit1 { get; set; }
        public bool FEMA { get; set; }
        public bool Hengsha1 { get; set; }
        public bool TaiYong1 { get; set; }
        public bool TaiYong2 { get; set; }
        public bool Picus { get; set; }
        public bool Detroit2 { get; set; }
        //Tongs Mission
        public bool TongsEnd { get; set; }
        //Normal Part
        public bool Hengsha2 { get; set; }
        //TML missions
        public bool TML_LeavingBoat { get; set; }
        public bool TML_UnderwaterElevator { get; set; }
        public bool TML_Finished { get; set; }
        //Normal
        public bool Singapore { get; set; }
        public bool Panchaea { get; set; }

        private const bool DEFAULT_AUTORESET = false;
        private const bool DEFAULT_AUTOSTART = true;
        private const bool DEFAULT_PROLOGUE = true;
        private const bool DEFAULT_SARIF = true;
        private const bool DEFAULT_DETROIT1 = true;
        private const bool DEFAULT_FEMA = true;
        private const bool DEFAULT_HENGSHA1 = true;
        private const bool DEFAULT_TAIYONG1 = true;
        private const bool DEFAULT_TAIYONG2 = true;
        private const bool DEFAULT_PICUS = true;
        private const bool DEFAULT_DETROIT2 = true;
        private const bool DEFAULT_TONGSEND = true;            //Tongs Mission
        private const bool DEFAULT_HENGSHA2 = true;
        private const bool DEFAULT_TML_LEAVINGBOAT = true;     //TML
        private const bool DEFAULT_TML_UNDERWATERELEVATOR = true;
        private const bool DEFAULT_TML_FINISHED = true;
        private const bool DEFAULT_SINGAPORE = true;
        private const bool DEFAULT_PANCHAEA = true;

        public DXHRSettings()
        {
            InitializeComponent();

            this.chkAutoReset.DataBindings.Add("Checked", this, "AutoReset", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkAutoStart.DataBindings.Add("Checked", this, "AutoStart", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkPrologue.DataBindings.Add("Checked", this, "Prologue", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkSarif.DataBindings.Add("Checked", this, "Sarif", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkFEMA.DataBindings.Add("Checked", this, "FEMA", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkDetroit1.DataBindings.Add("Checked", this, "Detroit1", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkHengsha1.DataBindings.Add("Checked", this, "Hengsha1", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkTaiYong1.DataBindings.Add("Checked", this, "TaiYong1", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkTaiYong2.DataBindings.Add("Checked", this, "TaiYong2", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkPicus.DataBindings.Add("Checked", this, "Picus", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkDetroit2.DataBindings.Add("Checked", this, "Detroit2", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkHengsha2.DataBindings.Add("Checked", this, "Hengsha2", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkSingapore.DataBindings.Add("Checked", this, "Singapore", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkPanchaea.DataBindings.Add("Checked", this, "Panchaea", false, DataSourceUpdateMode.OnPropertyChanged);

            //Directors Cut
            this.chkDCTongsEnd.DataBindings.Add("Checked", this, "TongsEnd", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkDC_TML_LeavingBoat.DataBindings.Add("Checked", this, "TML_LeavingBoat", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkDC_TML_UnderwaterElevator.DataBindings.Add("Checked", this, "TML_UnderwaterElevator", false, DataSourceUpdateMode.OnPropertyChanged);
            this.chkDC_TML_EndOfDLC.DataBindings.Add("Checked", this, "TML_Finished", false, DataSourceUpdateMode.OnPropertyChanged);

            // defaults
            this.AutoReset = DEFAULT_AUTORESET;
            this.AutoStart = DEFAULT_AUTOSTART;
            this.Prologue = DEFAULT_PROLOGUE;
            this.Sarif = DEFAULT_SARIF;
            this.FEMA = DEFAULT_FEMA;
            this.Detroit1 = DEFAULT_DETROIT1;
            this.Hengsha1 = DEFAULT_HENGSHA1;
            this.TaiYong1 = DEFAULT_TAIYONG1;
            this.TaiYong2 = DEFAULT_TAIYONG2;
            this.Picus = DEFAULT_PICUS;
            this.Detroit2 = DEFAULT_DETROIT2;
            this.TongsEnd = DEFAULT_TONGSEND;   //TongsEnd
            this.Hengsha2 = DEFAULT_HENGSHA2;
            this.TML_LeavingBoat = DEFAULT_TML_LEAVINGBOAT;
            this.TML_UnderwaterElevator = DEFAULT_TML_UNDERWATERELEVATOR;
            this.TML_Finished = DEFAULT_TML_FINISHED;
            this.Singapore = DEFAULT_SINGAPORE;
            this.Panchaea = DEFAULT_PANCHAEA;
        }

        public XmlNode GetSettings(XmlDocument doc)
        {
            XmlElement settingsNode = doc.CreateElement("Settings");

            settingsNode.AppendChild(ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

            settingsNode.AppendChild(ToElement(doc, "AutoReset", this.AutoReset));
            settingsNode.AppendChild(ToElement(doc, "AutoStart", this.AutoStart));
            settingsNode.AppendChild(ToElement(doc, "Prologue", this.Prologue));
            settingsNode.AppendChild(ToElement(doc, "Sarif", this.Sarif));
            settingsNode.AppendChild(ToElement(doc, "Detroit1", this.Detroit1));
            settingsNode.AppendChild(ToElement(doc, "FEMA", this.FEMA));
            settingsNode.AppendChild(ToElement(doc, "Hengsha1", this.Hengsha1));
            settingsNode.AppendChild(ToElement(doc, "TaiYong1", this.TaiYong1));
            settingsNode.AppendChild(ToElement(doc, "TaiYong2", this.TaiYong2));
            settingsNode.AppendChild(ToElement(doc, "Picus", this.Picus));
            settingsNode.AppendChild(ToElement(doc, "Detroit2", this.Detroit2));
            settingsNode.AppendChild(ToElement(doc, "TongsEnd", this.TongsEnd));
            settingsNode.AppendChild(ToElement(doc, "Hengsha2", this.Hengsha2));
            settingsNode.AppendChild(ToElement(doc, "TML_LeavingBoat", this.TML_LeavingBoat));
            settingsNode.AppendChild(ToElement(doc, "TML_UnderwaterElevator", this.TML_UnderwaterElevator));
            settingsNode.AppendChild(ToElement(doc, "TML_FinishedTML", this.TML_Finished));
            settingsNode.AppendChild(ToElement(doc, "Singapore", this.Singapore));
            settingsNode.AppendChild(ToElement(doc, "Panchaea", this.Panchaea));

            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            this.AutoReset = ParseBool(settings, "AutoReset", DEFAULT_AUTORESET);
            this.AutoStart = ParseBool(settings, "AutoStart", DEFAULT_AUTOSTART);
            this.Prologue = ParseBool(settings, "Prologue", DEFAULT_PROLOGUE);
            this.Sarif = ParseBool(settings, "Sarif", DEFAULT_SARIF);
            this.Detroit1 = ParseBool(settings, "Detroit1", DEFAULT_DETROIT1);
            this.FEMA = ParseBool(settings, "FEMA", DEFAULT_FEMA);
            this.Hengsha1 = ParseBool(settings, "Hengsha1", DEFAULT_HENGSHA1);
            this.TaiYong1 = ParseBool(settings, "TaiYong1", DEFAULT_TAIYONG1);
            this.TaiYong2 = ParseBool(settings, "TaiYong2", DEFAULT_TAIYONG2);
            this.Picus = ParseBool(settings, "Picus", DEFAULT_PICUS);
            this.Detroit2 = ParseBool(settings, "Detroit2", DEFAULT_DETROIT2);
            this.TongsEnd = ParseBool(settings, "TongsEnd", DEFAULT_TONGSEND);
            this.Hengsha2 = ParseBool(settings, "Hengsha2", DEFAULT_HENGSHA2);
            this.TML_LeavingBoat = ParseBool(settings, "TML_LeavingBoat", DEFAULT_TML_LEAVINGBOAT);
            this.TML_UnderwaterElevator = ParseBool(settings, "TML_UnderwaterElevator", DEFAULT_TML_UNDERWATERELEVATOR);
            this.TML_Finished = ParseBool(settings, "TML_FinishedTML", DEFAULT_TML_FINISHED);
            this.Singapore = ParseBool(settings, "Singapore", DEFAULT_SINGAPORE);
            this.Panchaea = ParseBool(settings, "Panchaea", DEFAULT_PANCHAEA);
        }

        static bool ParseBool(XmlNode settings, string setting, bool default_ = false)
        {
            bool val;
            return settings[setting] != null ?
                (Boolean.TryParse(settings[setting].InnerText, out val) ? val : default_)
                : default_;
        }

        static XmlElement ToElement<T>(XmlDocument document, string name, T value)
        {
            XmlElement str = document.CreateElement(name);
            str.InnerText = value.ToString();
            return str;
        }
    }
}
