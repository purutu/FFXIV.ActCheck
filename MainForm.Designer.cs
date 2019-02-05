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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(12, 12);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(130, 45);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "검사하기";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnSetting
            // 
            this.BtnSetting.Location = new System.Drawing.Point(173, 12);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(130, 45);
            this.BtnSetting.TabIndex = 1;
            this.BtnSetting.Text = "설정하기";
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(512, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 26);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "바로 끝내기";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ACT 경로";
            // 
            // TxtActPath
            // 
            this.TxtActPath.BackColor = System.Drawing.SystemColors.Info;
            this.TxtActPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtActPath.Location = new System.Drawing.Point(71, 279);
            this.TxtActPath.Name = "TxtActPath";
            this.TxtActPath.ReadOnly = true;
            this.TxtActPath.Size = new System.Drawing.Size(232, 20);
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
            this.LstResult.Location = new System.Drawing.Point(15, 63);
            this.LstResult.Name = "LstResult";
            this.LstResult.Size = new System.Drawing.Size(288, 210);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(438, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nanamo Ul Namo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FFActCheck.Properties.Resources.nanamo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(624, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LstResult);
            this.Controls.Add(this.TxtActPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSetting);
            this.Controls.Add(this.BtnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "FF14 ACT 실행 환경 검사 도구";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Label label2;
    }
}

