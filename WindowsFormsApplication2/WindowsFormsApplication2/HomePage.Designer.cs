namespace WindowsFormsApplication2
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.picWeb = new System.Windows.Forms.PictureBox();
            this.picDatabase = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(1241, 11);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(32, 26);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "X";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btnMinimize.Appearance.Options.UseFont = true;
            this.btnMinimize.Appearance.Options.UseForeColor = true;
            this.btnMinimize.Location = new System.Drawing.Point(1201, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 26);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "-";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl1.Location = new System.Drawing.Point(579, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(160, 18);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Internet of Things";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Location = new System.Drawing.Point(-1, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1286, 45);
            this.panel3.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Location = new System.Drawing.Point(-1, 753);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 72);
            this.panel2.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl2.Location = new System.Drawing.Point(583, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(151, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "CopyRight @ 2015";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.picSettings);
            this.panel1.Controls.Add(this.picAbout);
            this.panel1.Controls.Add(this.picWeb);
            this.panel1.Controls.Add(this.picDatabase);
            this.panel1.Controls.Add(this.picHome);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.imageSlider1);
            this.panel1.Location = new System.Drawing.Point(-1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 787);
            this.panel1.TabIndex = 3;
            // 
            // picSettings
            // 
            this.picSettings.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.a1228223;
            this.picSettings.Location = new System.Drawing.Point(0, 584);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(60, 60);
            this.picSettings.TabIndex = 9;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // picAbout
            // 
            this.picAbout.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.info;
            this.picAbout.Location = new System.Drawing.Point(0, 648);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(60, 60);
            this.picAbout.TabIndex = 8;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // picWeb
            // 
            this.picWeb.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.web1;
            this.picWeb.Location = new System.Drawing.Point(0, 240);
            this.picWeb.Name = "picWeb";
            this.picWeb.Size = new System.Drawing.Size(60, 60);
            this.picWeb.TabIndex = 7;
            this.picWeb.TabStop = false;
            this.picWeb.Click += new System.EventHandler(this.picWeb_Click);
            // 
            // picDatabase
            // 
            this.picDatabase.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.database3;
            this.picDatabase.Location = new System.Drawing.Point(0, 174);
            this.picDatabase.Name = "picDatabase";
            this.picDatabase.Size = new System.Drawing.Size(60, 63);
            this.picDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDatabase.TabIndex = 6;
            this.picDatabase.TabStop = false;
            this.picDatabase.Click += new System.EventHandler(this.picDatabase_Click);
            // 
            // picHome
            // 
            this.picHome.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Home__1_;
            this.picHome.Location = new System.Drawing.Point(0, 48);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(60, 60);
            this.picHome.TabIndex = 5;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.statistic;
            this.pictureBox2.Location = new System.Drawing.Point(0, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider1.Location = new System.Drawing.Point(0, 1);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(61, 42);
            this.imageSlider1.TabIndex = 2;
            this.imageSlider1.Text = "imageSlider1";
            this.imageSlider1.UseDisabledStatePainter = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picDatabase;
        private System.Windows.Forms.PictureBox picSettings;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.PictureBox picWeb;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}