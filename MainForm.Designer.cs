namespace FFActCheck
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.BtnTest = new System.Windows.Forms.Button();
			this.BtnSetting = new System.Windows.Forms.Button();
			this.BtnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtActPath = new System.Windows.Forms.TextBox();
			this.IlOx = new System.Windows.Forms.ImageList(this.components);
			this.LstResult = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ChkCfgUseHojoring = new System.Windows.Forms.CheckBox();
			this.BtnConfig = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnTest
			// 
			this.BtnTest.BackColor = System.Drawing.Color.Pink;
			this.BtnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnTest.Location = new System.Drawing.Point(3, 9);
			this.BtnTest.Name = "BtnTest";
			this.BtnTest.Size = new System.Drawing.Size(150, 45);
			this.BtnTest.TabIndex = 0;
			this.BtnTest.Text = "환경 검사 하기";
			this.BtnTest.UseVisualStyleBackColor = false;
			this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
			// 
			// BtnSetting
			// 
			this.BtnSetting.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BtnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSetting.Location = new System.Drawing.Point(3, 60);
			this.BtnSetting.Name = "BtnSetting";
			this.BtnSetting.Size = new System.Drawing.Size(150, 45);
			this.BtnSetting.TabIndex = 1;
			this.BtnSetting.Text = "환경 설정하기";
			this.BtnSetting.UseVisualStyleBackColor = false;
			this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
			// 
			// BtnClose
			// 
			this.BtnClose.BackColor = System.Drawing.Color.Maroon;
			this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnClose.ForeColor = System.Drawing.Color.White;
			this.BtnClose.Location = new System.Drawing.Point(12, 337);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(124, 45);
			this.BtnClose.TabIndex = 2;
			this.BtnClose.Text = "바로 끝내기";
			this.BtnClose.UseVisualStyleBackColor = false;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 249);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "ACT 경로";
			// 
			// TxtActPath
			// 
			this.TxtActPath.BackColor = System.Drawing.SystemColors.Info;
			this.TxtActPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtActPath.Location = new System.Drawing.Point(68, 247);
			this.TxtActPath.Name = "TxtActPath";
			this.TxtActPath.ReadOnly = true;
			this.TxtActPath.Size = new System.Drawing.Size(397, 20);
			this.TxtActPath.TabIndex = 5;
			// 
			// IlOx
			// 
			this.IlOx.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IlOx.ImageStream")));
			this.IlOx.TransparentColor = System.Drawing.Color.Transparent;
			this.IlOx.Images.SetKeyName(0, "donotdoit.png");
			this.IlOx.Images.SetKeyName(1, "checkbutton.png");
			// 
			// LstResult
			// 
			this.LstResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LstResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.LstResult.HideSelection = false;
			this.LstResult.Location = new System.Drawing.Point(180, 28);
			this.LstResult.Name = "LstResult";
			this.LstResult.Size = new System.Drawing.Size(285, 204);
			this.LstResult.SmallImageList = this.IlOx;
			this.LstResult.TabIndex = 6;
			this.LstResult.UseCompatibleStateImageBehavior = false;
			this.LstResult.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "항목";
			this.columnHeader1.Width = 110;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "내용";
			this.columnHeader2.Width = 173;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.BtnTest);
			this.panel2.Controls.Add(this.BtnSetting);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(162, 116);
			this.panel2.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.ChkCfgUseHojoring);
			this.panel1.Controls.Add(this.BtnConfig);
			this.panel1.Location = new System.Drawing.Point(12, 146);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(162, 86);
			this.panel1.TabIndex = 11;
			// 
			// ChkCfgUseHojoring
			// 
			this.ChkCfgUseHojoring.AutoSize = true;
			this.ChkCfgUseHojoring.Checked = true;
			this.ChkCfgUseHojoring.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChkCfgUseHojoring.Location = new System.Drawing.Point(41, 59);
			this.ChkCfgUseHojoring.Name = "ChkCfgUseHojoring";
			this.ChkCfgUseHojoring.Size = new System.Drawing.Size(109, 17);
			this.ChkCfgUseHojoring.TabIndex = 14;
			this.ChkCfgUseHojoring.Text = "Yukkuri 사용하기";
			this.ChkCfgUseHojoring.UseVisualStyleBackColor = true;
			// 
			// BtnConfig
			// 
			this.BtnConfig.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.BtnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConfig.Location = new System.Drawing.Point(3, 8);
			this.BtnConfig.Name = "BtnConfig";
			this.BtnConfig.Size = new System.Drawing.Size(150, 45);
			this.BtnConfig.TabIndex = 2;
			this.BtnConfig.Text = "설정 파일 만들기";
			this.BtnConfig.UseVisualStyleBackColor = false;
			this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(180, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "수행 내역 로그";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FFActCheck.Properties.Resources.nanamo;
			this.pictureBox1.Location = new System.Drawing.Point(210, 273);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 109);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(482, 394);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.LstResult);
			this.Controls.Add(this.TxtActPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "FF14 ACT 실행 환경 검사 도구 / 2019-11-18 빌드판";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtActPath;
        private System.Windows.Forms.ImageList IlOx;
        private System.Windows.Forms.ListView LstResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox ChkCfgUseHojoring;
	}
}

