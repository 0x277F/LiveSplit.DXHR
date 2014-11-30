namespace LiveSplit.DXHR
{
    partial class DXHRSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbStartSplits = new System.Windows.Forms.GroupBox();
            this.tlpStartSplits = new System.Windows.Forms.TableLayoutPanel();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.gbEndSplits = new System.Windows.Forms.GroupBox();
            this.tlpEndSplits = new System.Windows.Forms.TableLayoutPanel();
            this.chkPrologue = new System.Windows.Forms.CheckBox();
            this.chkSarif = new System.Windows.Forms.CheckBox();
            this.chkDetroit1 = new System.Windows.Forms.CheckBox();
            this.chkFEMA = new System.Windows.Forms.CheckBox();
            this.chkHengsha1 = new System.Windows.Forms.CheckBox();
            this.chkTaiYong1 = new System.Windows.Forms.CheckBox();
            this.chkTaiYong2 = new System.Windows.Forms.CheckBox();
            this.chkPicus = new System.Windows.Forms.CheckBox();
            this.chkDetroit2 = new System.Windows.Forms.CheckBox();
            this.chkHengsha2 = new System.Windows.Forms.CheckBox();
            this.chkSingapore = new System.Windows.Forms.CheckBox();
            this.chkPanchaea = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.gbStartSplits.SuspendLayout();
            this.tlpStartSplits.SuspendLayout();
            this.gbEndSplits.SuspendLayout();
            this.tlpEndSplits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gbStartSplits, 0, 0);
            this.tlpMain.Controls.Add(this.gbEndSplits, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(476, 309);
            this.tlpMain.TabIndex = 0;
            // 
            // gbStartSplits
            // 
            this.gbStartSplits.AutoSize = true;
            this.gbStartSplits.Controls.Add(this.tlpStartSplits);
            this.gbStartSplits.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbStartSplits.Location = new System.Drawing.Point(3, 3);
            this.gbStartSplits.Name = "gbStartSplits";
            this.gbStartSplits.Size = new System.Drawing.Size(470, 42);
            this.gbStartSplits.TabIndex = 5;
            this.gbStartSplits.TabStop = false;
            this.gbStartSplits.Text = "Start Auto-splits";
            // 
            // tlpStartSplits
            // 
            this.tlpStartSplits.AutoSize = true;
            this.tlpStartSplits.BackColor = System.Drawing.Color.Transparent;
            this.tlpStartSplits.ColumnCount = 1;
            this.tlpStartSplits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartSplits.Controls.Add(this.chkAutoStart, 0, 0);
            this.tlpStartSplits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartSplits.Location = new System.Drawing.Point(3, 16);
            this.tlpStartSplits.Name = "tlpStartSplits";
            this.tlpStartSplits.RowCount = 2;
            this.tlpStartSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStartSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStartSplits.Size = new System.Drawing.Size(464, 23);
            this.tlpStartSplits.TabIndex = 4;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Checked = true;
            this.chkAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoStart.Location = new System.Drawing.Point(3, 3);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(87, 17);
            this.chkAutoStart.TabIndex = 4;
            this.chkAutoStart.Text = "Start / Reset";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // gbEndSplits
            // 
            this.gbEndSplits.AutoSize = true;
            this.gbEndSplits.Controls.Add(this.tlpEndSplits);
            this.gbEndSplits.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEndSplits.Location = new System.Drawing.Point(3, 51);
            this.gbEndSplits.Name = "gbEndSplits";
            this.gbEndSplits.Size = new System.Drawing.Size(470, 295);
            this.gbEndSplits.TabIndex = 7;
            this.gbEndSplits.TabStop = false;
            this.gbEndSplits.Text = "Any% Auto-splits";
            // 
            // tlpEndSplits
            // 
            this.tlpEndSplits.AutoSize = true;
            this.tlpEndSplits.BackColor = System.Drawing.Color.Transparent;
            this.tlpEndSplits.ColumnCount = 1;
            this.tlpEndSplits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEndSplits.Controls.Add(this.chkPrologue, 0, 0);
            this.tlpEndSplits.Controls.Add(this.chkSarif, 0, 4);
            this.tlpEndSplits.Controls.Add(this.chkDetroit1, 0, 5);
            this.tlpEndSplits.Controls.Add(this.chkFEMA, 0, 6);
            this.tlpEndSplits.Controls.Add(this.chkHengsha1, 0, 7);
            this.tlpEndSplits.Controls.Add(this.chkTaiYong1, 0, 7);
            this.tlpEndSplits.Controls.Add(this.chkTaiYong2, 0, 8);
            this.tlpEndSplits.Controls.Add(this.chkPicus, 0, 10);
            this.tlpEndSplits.Controls.Add(this.chkDetroit2, 0, 11);
            this.tlpEndSplits.Controls.Add(this.chkHengsha2, 0, 12);
            this.tlpEndSplits.Controls.Add(this.chkSingapore, 0, 13);
            this.tlpEndSplits.Controls.Add(this.chkPanchaea, 0, 14);
            this.tlpEndSplits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEndSplits.Location = new System.Drawing.Point(3, 16);
            this.tlpEndSplits.MinimumSize = new System.Drawing.Size(0, 276);
            this.tlpEndSplits.Name = "tlpEndSplits";
            this.tlpEndSplits.RowCount = 11;
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.Size = new System.Drawing.Size(464, 276);
            this.tlpEndSplits.TabIndex = 4;
            // 
            // chkPrologue
            // 
            this.chkPrologue.AutoSize = true;
            this.chkPrologue.Checked = true;
            this.chkPrologue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrologue.Location = new System.Drawing.Point(3, 3);
            this.chkPrologue.Name = "chkPrologue";
            this.chkPrologue.Size = new System.Drawing.Size(68, 17);
            this.chkPrologue.TabIndex = 7;
            this.chkPrologue.Text = "Prologue";
            this.chkPrologue.UseVisualStyleBackColor = true;
            // 
            // chkSarif
            // 
            this.chkSarif.AutoSize = true;
            this.chkSarif.Checked = true;
            this.chkSarif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSarif.Location = new System.Drawing.Point(3, 26);
            this.chkSarif.Name = "chkSarif";
            this.chkSarif.Size = new System.Drawing.Size(47, 17);
            this.chkSarif.TabIndex = 6;
            this.chkSarif.Text = "Sarif";
            this.chkSarif.UseVisualStyleBackColor = true;
            // 
            // chkDetroit1
            // 
            this.chkDetroit1.AutoSize = true;
            this.chkDetroit1.Checked = true;
            this.chkDetroit1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetroit1.Location = new System.Drawing.Point(3, 49);
            this.chkDetroit1.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkDetroit1.Name = "chkDetroit1";
            this.chkDetroit1.Size = new System.Drawing.Size(66, 17);
            this.chkDetroit1.TabIndex = 8;
            this.chkDetroit1.Text = "Detroit 1";
            this.chkDetroit1.UseVisualStyleBackColor = true;
            // 
            // chkFEMA
            // 
            this.chkFEMA.AutoSize = true;
            this.chkFEMA.Checked = true;
            this.chkFEMA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFEMA.Location = new System.Drawing.Point(3, 69);
            this.chkFEMA.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkFEMA.Name = "chkFEMA";
            this.chkFEMA.Size = new System.Drawing.Size(55, 17);
            this.chkFEMA.TabIndex = 9;
            this.chkFEMA.Text = "FEMA";
            this.chkFEMA.UseVisualStyleBackColor = true;
            // 
            // chkHengsha1
            // 
            this.chkHengsha1.AutoSize = true;
            this.chkHengsha1.Checked = true;
            this.chkHengsha1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHengsha1.Location = new System.Drawing.Point(3, 109);
            this.chkHengsha1.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkHengsha1.Name = "chkHengsha1";
            this.chkHengsha1.Size = new System.Drawing.Size(78, 17);
            this.chkHengsha1.TabIndex = 10;
            this.chkHengsha1.Text = "Hengsha 1";
            this.chkHengsha1.UseVisualStyleBackColor = true;
            // 
            // chkTaiYong1
            // 
            this.chkTaiYong1.AutoSize = true;
            this.chkTaiYong1.Checked = true;
            this.chkTaiYong1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTaiYong1.Location = new System.Drawing.Point(3, 89);
            this.chkTaiYong1.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkTaiYong1.Name = "chkTaiYong1";
            this.chkTaiYong1.Size = new System.Drawing.Size(101, 17);
            this.chkTaiYong1.TabIndex = 11;
            this.chkTaiYong1.Text = "Tai Yong Lower";
            this.chkTaiYong1.UseVisualStyleBackColor = true;
            // 
            // chkTaiYong2
            // 
            this.chkTaiYong2.AutoSize = true;
            this.chkTaiYong2.Checked = true;
            this.chkTaiYong2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTaiYong2.Location = new System.Drawing.Point(3, 129);
            this.chkTaiYong2.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkTaiYong2.Name = "chkTaiYong2";
            this.chkTaiYong2.Size = new System.Drawing.Size(101, 17);
            this.chkTaiYong2.TabIndex = 12;
            this.chkTaiYong2.Text = "Tai Yong Upper";
            this.chkTaiYong2.UseVisualStyleBackColor = true;
            // 
            // chkPicus
            // 
            this.chkPicus.AutoSize = true;
            this.chkPicus.Checked = true;
            this.chkPicus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPicus.Location = new System.Drawing.Point(3, 149);
            this.chkPicus.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkPicus.Name = "chkPicus";
            this.chkPicus.Size = new System.Drawing.Size(52, 17);
            this.chkPicus.TabIndex = 13;
            this.chkPicus.Text = "Picus";
            this.chkPicus.UseVisualStyleBackColor = true;
            // 
            // chkDetroit2
            // 
            this.chkDetroit2.AutoSize = true;
            this.chkDetroit2.Checked = true;
            this.chkDetroit2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetroit2.Location = new System.Drawing.Point(3, 169);
            this.chkDetroit2.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkDetroit2.Name = "chkDetroit2";
            this.chkDetroit2.Size = new System.Drawing.Size(66, 17);
            this.chkDetroit2.TabIndex = 5;
            this.chkDetroit2.Text = "Detroit 2";
            this.chkDetroit2.UseVisualStyleBackColor = true;
            // 
            // chkHengsha2
            // 
            this.chkHengsha2.AutoSize = true;
            this.chkHengsha2.Checked = true;
            this.chkHengsha2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHengsha2.Location = new System.Drawing.Point(3, 189);
            this.chkHengsha2.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkHengsha2.Name = "chkHengsha2";
            this.chkHengsha2.Size = new System.Drawing.Size(78, 17);
            this.chkHengsha2.TabIndex = 12;
            this.chkHengsha2.Text = "Hengsha 2";
            this.chkHengsha2.UseVisualStyleBackColor = true;
            // 
            // chkSingapore
            // 
            this.chkSingapore.AutoSize = true;
            this.chkSingapore.Checked = true;
            this.chkSingapore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSingapore.Location = new System.Drawing.Point(3, 209);
            this.chkSingapore.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkSingapore.Name = "chkSingapore";
            this.chkSingapore.Size = new System.Drawing.Size(74, 17);
            this.chkSingapore.TabIndex = 12;
            this.chkSingapore.Text = "Singapore";
            this.chkSingapore.UseVisualStyleBackColor = true;
            // 
            // chkPanchaea
            // 
            this.chkPanchaea.Checked = true;
            this.chkPanchaea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPanchaea.Location = new System.Drawing.Point(3, 229);
            this.chkPanchaea.MinimumSize = new System.Drawing.Size(0, 17);
            this.chkPanchaea.Name = "chkPanchaea";
            this.chkPanchaea.Size = new System.Drawing.Size(75, 17);
            this.chkPanchaea.TabIndex = 12;
            this.chkPanchaea.Text = "Panchaea";
            this.chkPanchaea.UseVisualStyleBackColor = true;
            // 
            // DXHRSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "DXHRSettings";
            this.Size = new System.Drawing.Size(476, 443);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.gbStartSplits.ResumeLayout(false);
            this.gbStartSplits.PerformLayout();
            this.tlpStartSplits.ResumeLayout(false);
            this.tlpStartSplits.PerformLayout();
            this.gbEndSplits.ResumeLayout(false);
            this.gbEndSplits.PerformLayout();
            this.tlpEndSplits.ResumeLayout(false);
            this.tlpEndSplits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbStartSplits;
        private System.Windows.Forms.GroupBox gbEndSplits;
        private System.Windows.Forms.TableLayoutPanel tlpEndSplits;
        private System.Windows.Forms.TableLayoutPanel tlpStartSplits;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkPrologue;
        private System.Windows.Forms.CheckBox chkSarif;
        private System.Windows.Forms.CheckBox chkDetroit1;
        private System.Windows.Forms.CheckBox chkFEMA;
        private System.Windows.Forms.CheckBox chkHengsha1;
        private System.Windows.Forms.CheckBox chkTaiYong1;
        private System.Windows.Forms.CheckBox chkTaiYong2;
        private System.Windows.Forms.CheckBox chkPicus;
        private System.Windows.Forms.CheckBox chkDetroit2;
        private System.Windows.Forms.CheckBox chkHengsha2;
        private System.Windows.Forms.CheckBox chkSingapore;
        private System.Windows.Forms.CheckBox chkPanchaea;
    }
}
