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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            removeColor();
            removePanels();
            panelIntro.Visible = true;
            lblIntroduction.ForeColor = Color.LightBlue;
        }

        public void removePanels()
        {
            panelIntro.Visible = false;
            panelAbout.Visible = false;
            panConnect.Visible = false;
            panelHow.Visible = false;
           
        }
        private void labelControl3_Click(object sender, EventArgs e)
        {
            removeColor();
            lblIntroduction.ForeColor = Color.LightBlue;
            removePanels();
            panelIntro.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {
            removeColor();
            lblHow.ForeColor = Color.LightBlue;
            removePanels();
            panelHow.Visible = true;
            
        }

        private void lblconnect_Click(object sender, EventArgs e)
        {
            removeColor();
            lblconnect.ForeColor = Color.LightBlue;
            removePanels();
            panConnect.Visible = true;
        }
        public void removeColor()
        {
            lblIntroduction.ForeColor = Color.Gray;
            lblAbout.ForeColor = Color.Gray;
            lblconnect.ForeColor = Color.Gray;
            lblHow.ForeColor = Color.Gray;

        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            removeColor();
            lblAbout.ForeColor = Color.LightBlue;
            removePanels();
            panelAbout.Visible = true;
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            removeColor();
            lblHelp.ForeColor = Color.LightBlue;
           
        }
    }
}
