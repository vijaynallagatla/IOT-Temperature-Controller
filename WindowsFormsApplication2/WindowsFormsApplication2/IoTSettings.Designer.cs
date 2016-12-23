namespace WindowsFormsApplication2
{
    partial class IoTSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IoTSettings));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHow = new DevExpress.XtraEditors.LabelControl();
            this.lblIntroduction = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panConnect = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblPort = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panConnect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Location = new System.Drawing.Point(69, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 65);
            this.panel3.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl2.Location = new System.Drawing.Point(7, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 18);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lblHow);
            this.panel2.Controls.Add(this.lblIntroduction);
            this.panel2.Location = new System.Drawing.Point(69, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 43);
            this.panel2.TabIndex = 10;
            // 
            // lblHow
            // 
            this.lblHow.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHow.Appearance.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHow.Location = new System.Drawing.Point(175, 12);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(138, 18);
            this.lblHow.TabIndex = 11;
            this.lblHow.Text = "Account Settings";
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIntroduction.Location = new System.Drawing.Point(21, 12);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(143, 18);
            this.lblIntroduction.TabIndex = 10;
            this.lblIntroduction.Text = "ComPort Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.panConnect);
            this.panel1.Location = new System.Drawing.Point(70, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 691);
            this.panel1.TabIndex = 12;
            // 
            // panConnect
            // 
            this.panConnect.Controls.Add(this.groupBox1);
            this.panConnect.Controls.Add(this.lblPort);
            this.panConnect.Controls.Add(this.labelControl3);
            this.panConnect.Controls.Add(this.labelControl1);
            this.panConnect.Controls.Add(this.label4);
            this.panConnect.Controls.Add(this.labelControl5);
            this.panConnect.Location = new System.Drawing.Point(20, 16);
            this.panConnect.Name = "panConnect";
            this.panConnect.Size = new System.Drawing.Size(1110, 516);
            this.panConnect.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1053, 55);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelControl5.Location = new System.Drawing.Point(20, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(168, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "How to Connect to Device";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelControl1.Location = new System.Drawing.Point(20, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 18);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Select COM Port";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(132, 36);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 12;
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(263, 34);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(135, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Select this Port";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(5, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "ADD new COM PORT";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelControl3.Location = new System.Drawing.Point(25, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 16);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Saved COM Port :";
            // 
            // lblPort
            // 
            this.lblPort.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Appearance.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPort.Location = new System.Drawing.Point(141, 154);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 16);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "PORT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(20, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 88);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select New Port";
            // 
            // IoTSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "IoTSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoTSettings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IoTSettings_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panConnect.ResumeLayout(false);
            this.panConnect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblHow;
        private DevExpress.XtraEditors.LabelControl lblIntroduction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panConnect;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private System.Windows.Forms.ComboBox cmbPort;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPort;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}