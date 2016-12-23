namespace WindowsFormsApplication2
{
    partial class Database
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iotDataSet2 = new WindowsFormsApplication2.iotDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltempC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltempK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltempF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhumidity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labTableAdapter = new WindowsFormsApplication2.iotDataSet2TableAdapters.labTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIntroduction = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iotDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.labBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(63, 161);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1202, 601);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labBindingSource
            // 
            this.labBindingSource.DataMember = "lab";
            this.labBindingSource.DataSource = this.iotDataSet2;
            // 
            // iotDataSet2
            // 
            this.iotDataSet2.DataSetName = "iotDataSet2";
            this.iotDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.coltempC,
            this.coltempK,
            this.coltempF,
            this.colhumidity,
            this.colrecord,
            this.coldates});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // coltempC
            // 
            this.coltempC.FieldName = "tempC";
            this.coltempC.Name = "coltempC";
            this.coltempC.Visible = true;
            this.coltempC.VisibleIndex = 1;
            // 
            // coltempK
            // 
            this.coltempK.FieldName = "tempK";
            this.coltempK.Name = "coltempK";
            this.coltempK.Visible = true;
            this.coltempK.VisibleIndex = 2;
            // 
            // coltempF
            // 
            this.coltempF.FieldName = "tempF";
            this.coltempF.Name = "coltempF";
            this.coltempF.Visible = true;
            this.coltempF.VisibleIndex = 3;
            // 
            // colhumidity
            // 
            this.colhumidity.FieldName = "humidity";
            this.colhumidity.Name = "colhumidity";
            this.colhumidity.Visible = true;
            this.colhumidity.VisibleIndex = 4;
            // 
            // colrecord
            // 
            this.colrecord.FieldName = "record";
            this.colrecord.Name = "colrecord";
            this.colrecord.Visible = true;
            this.colrecord.VisibleIndex = 5;
            // 
            // coldates
            // 
            this.coldates.FieldName = "dates";
            this.coldates.Name = "coldates";
            this.coldates.Visible = true;
            this.coldates.VisibleIndex = 6;
            // 
            // labTableAdapter
            // 
            this.labTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Location = new System.Drawing.Point(63, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 65);
            this.panel3.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl2.Location = new System.Drawing.Point(8, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 18);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Database";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lblIntroduction);
            this.panel2.Location = new System.Drawing.Point(63, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 43);
            this.panel2.TabIndex = 10;
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIntroduction.Location = new System.Drawing.Point(8, 19);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(285, 18);
            this.lblIntroduction.TabIndex = 10;
            this.lblIntroduction.Text = "Complete History of recorded Data";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iotDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private iotDataSet2 iotDataSet2;
        private System.Windows.Forms.BindingSource labBindingSource;
        private iotDataSet2TableAdapters.labTableAdapter labTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn coltempC;
        private DevExpress.XtraGrid.Columns.GridColumn coltempK;
        private DevExpress.XtraGrid.Columns.GridColumn coltempF;
        private DevExpress.XtraGrid.Columns.GridColumn colhumidity;
        private DevExpress.XtraGrid.Columns.GridColumn colrecord;
        private DevExpress.XtraGrid.Columns.GridColumn coldates;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblIntroduction;
    }
}