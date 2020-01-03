namespace FFActCheck
{
    partial class CheckForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpCheck = new System.Windows.Forms.TabPage();
			this.lstRuntime = new System.Windows.Forms.ListBox();
			this.btnCheckRuntime = new System.Windows.Forms.Button();
			this.btnSetRuntime = new System.Windows.Forms.Button();
			this.tpConfig = new System.Windows.Forms.TabPage();
			this.tpExtra = new System.Windows.Forms.TabPage();
			this.lblActLocation = new System.Windows.Forms.Label();
			this.txtActLocation = new System.Windows.Forms.TextBox();
			this.cboLanguage = new System.Windows.Forms.ComboBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblCfgConfigs = new System.Windows.Forms.Label();
			this.chkCfgHojoringYukkuri = new System.Windows.Forms.CheckBox();
			this.chkCfgHojoringUltsc = new System.Windows.Forms.CheckBox();
			this.chkCfgPing = new System.Windows.Forms.CheckBox();
			this.chkCfgDfassist = new System.Windows.Forms.CheckBox();
			this.lblCfgOverlay = new System.Windows.Forms.Label();
			this.rdoOvHoriz = new System.Windows.Forms.RadioButton();
			this.rdoOvKagerou = new System.Windows.Forms.RadioButton();
			this.chkOvEnmity = new System.Windows.Forms.CheckBox();
			this.chkOvEureka = new System.Windows.Forms.CheckBox();
			this.chkOvFish = new System.Windows.Forms.CheckBox();
			this.chkIknowOverwrite = new System.Windows.Forms.CheckBox();
			this.btnCfgWrite = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tpCheck.SuspendLayout();
			this.tpConfig.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpCheck);
			this.tabControl1.Controls.Add(this.tpConfig);
			this.tabControl1.Controls.Add(this.tpExtra);
			this.tabControl1.Location = new System.Drawing.Point(12, 67);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(538, 375);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tpCheck
			// 
			this.tpCheck.Controls.Add(this.lstRuntime);
			this.tpCheck.Controls.Add(this.btnCheckRuntime);
			this.tpCheck.Controls.Add(this.btnSetRuntime);
			this.tpCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpCheck.Location = new System.Drawing.Point(4, 22);
			this.tpCheck.Name = "tpCheck";
			this.tpCheck.Padding = new System.Windows.Forms.Padding(3);
			this.tpCheck.Size = new System.Drawing.Size(530, 349);
			this.tpCheck.TabIndex = 0;
			this.tpCheck.Text = "$CHECK";
			this.tpCheck.UseVisualStyleBackColor = true;
			// 
			// lstRuntime
			// 
			this.lstRuntime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.lstRuntime.FormattingEnabled = true;
			this.lstRuntime.ItemHeight = 24;
			this.lstRuntime.Location = new System.Drawing.Point(6, 66);
			this.lstRuntime.Name = "lstRuntime";
			this.lstRuntime.Size = new System.Drawing.Size(518, 268);
			this.lstRuntime.TabIndex = 4;
			// 
			// btnCheckRuntime
			// 
			this.btnCheckRuntime.BackColor = System.Drawing.Color.Pink;
			this.btnCheckRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckRuntime.Location = new System.Drawing.Point(54, 15);
			this.btnCheckRuntime.Name = "btnCheckRuntime";
			this.btnCheckRuntime.Size = new System.Drawing.Size(150, 45);
			this.btnCheckRuntime.TabIndex = 2;
			this.btnCheckRuntime.Text = "$CHECK";
			this.btnCheckRuntime.UseVisualStyleBackColor = false;
			this.btnCheckRuntime.Click += new System.EventHandler(this.btnCheckRuntime_Click);
			// 
			// btnSetRuntime
			// 
			this.btnSetRuntime.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnSetRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetRuntime.Location = new System.Drawing.Point(308, 15);
			this.btnSetRuntime.Name = "btnSetRuntime";
			this.btnSetRuntime.Size = new System.Drawing.Size(150, 45);
			this.btnSetRuntime.TabIndex = 3;
			this.btnSetRuntime.Text = "$SET";
			this.btnSetRuntime.UseVisualStyleBackColor = false;
			this.btnSetRuntime.Click += new System.EventHandler(this.btnSetRuntime_Click);
			// 
			// tpConfig
			// 
			this.tpConfig.Controls.Add(this.btnCfgWrite);
			this.tpConfig.Controls.Add(this.chkIknowOverwrite);
			this.tpConfig.Controls.Add(this.chkOvFish);
			this.tpConfig.Controls.Add(this.chkOvEureka);
			this.tpConfig.Controls.Add(this.chkOvEnmity);
			this.tpConfig.Controls.Add(this.rdoOvKagerou);
			this.tpConfig.Controls.Add(this.rdoOvHoriz);
			this.tpConfig.Controls.Add(this.lblCfgOverlay);
			this.tpConfig.Controls.Add(this.chkCfgDfassist);
			this.tpConfig.Controls.Add(this.chkCfgPing);
			this.tpConfig.Controls.Add(this.chkCfgHojoringUltsc);
			this.tpConfig.Controls.Add(this.chkCfgHojoringYukkuri);
			this.tpConfig.Controls.Add(this.lblCfgConfigs);
			this.tpConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpConfig.Location = new System.Drawing.Point(4, 22);
			this.tpConfig.Name = "tpConfig";
			this.tpConfig.Padding = new System.Windows.Forms.Padding(3);
			this.tpConfig.Size = new System.Drawing.Size(530, 349);
			this.tpConfig.TabIndex = 1;
			this.tpConfig.Text = "$CONFIG";
			this.tpConfig.UseVisualStyleBackColor = true;
			// 
			// tpExtra
			// 
			this.tpExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpExtra.Location = new System.Drawing.Point(4, 22);
			this.tpExtra.Name = "tpExtra";
			this.tpExtra.Size = new System.Drawing.Size(530, 349);
			this.tpExtra.TabIndex = 2;
			this.tpExtra.Text = "$EXTRA";
			this.tpExtra.UseVisualStyleBackColor = true;
			// 
			// lblActLocation
			// 
			this.lblActLocation.AutoSize = true;
			this.lblActLocation.Location = new System.Drawing.Point(14, 44);
			this.lblActLocation.Name = "lblActLocation";
			this.lblActLocation.Size = new System.Drawing.Size(88, 13);
			this.lblActLocation.TabIndex = 1;
			this.lblActLocation.Text = "$ACTLOCATION";
			// 
			// txtActLocation
			// 
			this.txtActLocation.BackColor = System.Drawing.Color.Cornsilk;
			this.txtActLocation.Location = new System.Drawing.Point(108, 41);
			this.txtActLocation.Name = "txtActLocation";
			this.txtActLocation.ReadOnly = true;
			this.txtActLocation.Size = new System.Drawing.Size(449, 20);
			this.txtActLocation.TabIndex = 2;
			// 
			// cboLanguage
			// 
			this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLanguage.FormattingEnabled = true;
			this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "한국말",
            "にほんご"});
			this.cboLanguage.Location = new System.Drawing.Point(12, 12);
			this.cboLanguage.Name = "cboLanguage";
			this.cboLanguage.Size = new System.Drawing.Size(88, 21);
			this.cboLanguage.TabIndex = 3;
			this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.LightCoral;
			this.btnExit.Location = new System.Drawing.Point(456, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(101, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "EXIT";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblCfgConfigs
			// 
			this.lblCfgConfigs.AutoSize = true;
			this.lblCfgConfigs.Location = new System.Drawing.Point(6, 3);
			this.lblCfgConfigs.Name = "lblCfgConfigs";
			this.lblCfgConfigs.Size = new System.Drawing.Size(143, 24);
			this.lblCfgConfigs.TabIndex = 0;
			this.lblCfgConfigs.Text = "$CFGCONFIGS";
			// 
			// chkCfgHojoringYukkuri
			// 
			this.chkCfgHojoringYukkuri.AutoSize = true;
			this.chkCfgHojoringYukkuri.Checked = true;
			this.chkCfgHojoringYukkuri.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCfgHojoringYukkuri.Location = new System.Drawing.Point(36, 34);
			this.chkCfgHojoringYukkuri.Name = "chkCfgHojoringYukkuri";
			this.chkCfgHojoringYukkuri.Size = new System.Drawing.Size(118, 28);
			this.chkCfgHojoringYukkuri.TabIndex = 1;
			this.chkCfgHojoringYukkuri.Text = "$YUKKURI";
			this.chkCfgHojoringYukkuri.UseVisualStyleBackColor = true;
			// 
			// chkCfgHojoringUltsc
			// 
			this.chkCfgHojoringUltsc.AutoSize = true;
			this.chkCfgHojoringUltsc.Location = new System.Drawing.Point(36, 68);
			this.chkCfgHojoringUltsc.Name = "chkCfgHojoringUltsc";
			this.chkCfgHojoringUltsc.Size = new System.Drawing.Size(114, 28);
			this.chkCfgHojoringUltsc.TabIndex = 2;
			this.chkCfgHojoringUltsc.Text = "$ULTSCO";
			this.chkCfgHojoringUltsc.UseVisualStyleBackColor = true;
			// 
			// chkCfgPing
			// 
			this.chkCfgPing.AutoSize = true;
			this.chkCfgPing.Checked = true;
			this.chkCfgPing.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCfgPing.Location = new System.Drawing.Point(36, 162);
			this.chkCfgPing.Name = "chkCfgPing";
			this.chkCfgPing.Size = new System.Drawing.Size(83, 28);
			this.chkCfgPing.TabIndex = 3;
			this.chkCfgPing.Text = "$PING";
			this.chkCfgPing.UseVisualStyleBackColor = true;
			// 
			// chkCfgDfassist
			// 
			this.chkCfgDfassist.AutoSize = true;
			this.chkCfgDfassist.Checked = true;
			this.chkCfgDfassist.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCfgDfassist.Location = new System.Drawing.Point(36, 128);
			this.chkCfgDfassist.Name = "chkCfgDfassist";
			this.chkCfgDfassist.Size = new System.Drawing.Size(129, 28);
			this.chkCfgDfassist.TabIndex = 4;
			this.chkCfgDfassist.Text = "$DFASSIST";
			this.chkCfgDfassist.UseVisualStyleBackColor = true;
			// 
			// lblCfgOverlay
			// 
			this.lblCfgOverlay.AutoSize = true;
			this.lblCfgOverlay.Location = new System.Drawing.Point(262, 3);
			this.lblCfgOverlay.Name = "lblCfgOverlay";
			this.lblCfgOverlay.Size = new System.Drawing.Size(148, 24);
			this.lblCfgOverlay.TabIndex = 5;
			this.lblCfgOverlay.Text = "$CFGOVERLAY";
			// 
			// rdoOvHoriz
			// 
			this.rdoOvHoriz.AutoSize = true;
			this.rdoOvHoriz.Checked = true;
			this.rdoOvHoriz.Location = new System.Drawing.Point(292, 34);
			this.rdoOvHoriz.Name = "rdoOvHoriz";
			this.rdoOvHoriz.Size = new System.Drawing.Size(96, 28);
			this.rdoOvHoriz.TabIndex = 6;
			this.rdoOvHoriz.TabStop = true;
			this.rdoOvHoriz.Text = "$HORIZ";
			this.rdoOvHoriz.UseVisualStyleBackColor = true;
			// 
			// rdoOvKagerou
			// 
			this.rdoOvKagerou.AutoSize = true;
			this.rdoOvKagerou.Location = new System.Drawing.Point(292, 68);
			this.rdoOvKagerou.Name = "rdoOvKagerou";
			this.rdoOvKagerou.Size = new System.Drawing.Size(131, 28);
			this.rdoOvKagerou.TabIndex = 7;
			this.rdoOvKagerou.Text = "$KAGEROU";
			this.rdoOvKagerou.UseVisualStyleBackColor = true;
			// 
			// chkOvEnmity
			// 
			this.chkOvEnmity.AutoSize = true;
			this.chkOvEnmity.Checked = true;
			this.chkOvEnmity.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkOvEnmity.Location = new System.Drawing.Point(292, 112);
			this.chkOvEnmity.Name = "chkOvEnmity";
			this.chkOvEnmity.Size = new System.Drawing.Size(110, 28);
			this.chkOvEnmity.TabIndex = 8;
			this.chkOvEnmity.Text = "$ENMITY";
			this.chkOvEnmity.UseVisualStyleBackColor = true;
			// 
			// chkOvEureka
			// 
			this.chkOvEureka.AutoSize = true;
			this.chkOvEureka.Location = new System.Drawing.Point(292, 146);
			this.chkOvEureka.Name = "chkOvEureka";
			this.chkOvEureka.Size = new System.Drawing.Size(116, 28);
			this.chkOvEureka.TabIndex = 9;
			this.chkOvEureka.Text = "$EUREKA";
			this.chkOvEureka.UseVisualStyleBackColor = true;
			// 
			// chkOvFish
			// 
			this.chkOvFish.AutoSize = true;
			this.chkOvFish.Location = new System.Drawing.Point(292, 180);
			this.chkOvFish.Name = "chkOvFish";
			this.chkOvFish.Size = new System.Drawing.Size(81, 28);
			this.chkOvFish.TabIndex = 10;
			this.chkOvFish.Text = "$FISH";
			this.chkOvFish.UseVisualStyleBackColor = true;
			// 
			// chkIknowOverwrite
			// 
			this.chkIknowOverwrite.AutoSize = true;
			this.chkIknowOverwrite.Location = new System.Drawing.Point(10, 264);
			this.chkIknowOverwrite.Name = "chkIknowOverwrite";
			this.chkIknowOverwrite.Size = new System.Drawing.Size(216, 28);
			this.chkIknowOverwrite.TabIndex = 11;
			this.chkIknowOverwrite.Text = "$IKNOWOVERWRITE";
			this.chkIknowOverwrite.UseVisualStyleBackColor = true;
			this.chkIknowOverwrite.CheckedChanged += new System.EventHandler(this.chkIknowOverwrite_CheckedChanged);
			// 
			// btnCfgWrite
			// 
			this.btnCfgWrite.BackColor = System.Drawing.SystemColors.Control;
			this.btnCfgWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCfgWrite.Location = new System.Drawing.Point(92, 298);
			this.btnCfgWrite.Name = "btnCfgWrite";
			this.btnCfgWrite.Size = new System.Drawing.Size(331, 45);
			this.btnCfgWrite.TabIndex = 12;
			this.btnCfgWrite.Text = "$CFGWRITE";
			this.btnCfgWrite.UseVisualStyleBackColor = false;
			this.btnCfgWrite.Click += new System.EventHandler(this.btnCfgWrite_Click);
			// 
			// CheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 454);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.cboLanguage);
			this.Controls.Add(this.txtActLocation);
			this.Controls.Add(this.lblActLocation);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CheckForm";
			this.Text = "$TITLE";
			this.tabControl1.ResumeLayout(false);
			this.tpCheck.ResumeLayout(false);
			this.tpConfig.ResumeLayout(false);
			this.tpConfig.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCheck;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.Label lblActLocation;
        private System.Windows.Forms.TextBox txtActLocation;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage tpExtra;
        private System.Windows.Forms.ListBox lstRuntime;
        private System.Windows.Forms.Button btnCheckRuntime;
        private System.Windows.Forms.Button btnSetRuntime;
		private System.Windows.Forms.Label lblCfgConfigs;
		private System.Windows.Forms.Label lblCfgOverlay;
		private System.Windows.Forms.CheckBox chkCfgDfassist;
		private System.Windows.Forms.CheckBox chkCfgPing;
		private System.Windows.Forms.CheckBox chkCfgHojoringUltsc;
		private System.Windows.Forms.CheckBox chkCfgHojoringYukkuri;
		private System.Windows.Forms.CheckBox chkOvFish;
		private System.Windows.Forms.CheckBox chkOvEureka;
		private System.Windows.Forms.CheckBox chkOvEnmity;
		private System.Windows.Forms.RadioButton rdoOvKagerou;
		private System.Windows.Forms.RadioButton rdoOvHoriz;
		private System.Windows.Forms.CheckBox chkIknowOverwrite;
		private System.Windows.Forms.Button btnCfgWrite;
	}
}