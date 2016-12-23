using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class HomePage : Form
    {
        Home frmHome = new Home();
        Form1 frmMain = new Form1();
        Database frmData = new Database();
        About frmAbout = new About();
        WebPreview webForm = new WebPreview();
        IoTSettings iotSettings = new IoTSettings();
        public HomePage()
        {
            InitializeComponent();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
            frmHome.MdiParent = this;
            
            
            frmHome.Show();
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frmMain = frm1;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            closeForms();
            
            frmMain.Show();
            //frmMain.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            closeForms();
        }

        public void closeForms()
        {
            frmHome.Close();
            iotSettings.Close();
            frmData.Close();
            frmAbout.Close();
            webForm.Close();
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            closeForms();
            Home frmHome1 = new Home();
            frmHome1.MdiParent = this;
            frmHome = frmHome1;
            frmHome1.Show();
         
        }

        private void picDatabase_Click(object sender, EventArgs e)
        {
            closeForms();
            Database frmDatabase = new Database();
            frmDatabase.MdiParent = this;
            frmData = frmDatabase;
            frmDatabase.Show();
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            closeForms();
            About abt = new About();
            frmAbout = abt;
            abt.Show();

          
        }

        private void picWeb_Click(object sender, EventArgs e)
        {
            closeForms();
            WebPreview web = new WebPreview();
            web.MdiParent = this;
            webForm = web;
            web.Show();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            closeForms();
            IoTSettings settings = new IoTSettings();
            settings.MdiParent = this;
            iotSettings = settings;
            settings.Show();
        }
    }
}
