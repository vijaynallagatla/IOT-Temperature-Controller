using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {

        private const int EM_SETCUEBANNER = 0x1501;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public Boolean logonSuccess = false;
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblLoginFailed.Visible = false; 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\project\iot.accdb";
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(string.Format("SELECT uname,password FROM login WHERE uname = '{0}'", uname.Text), con);

                OleDbDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    logonSuccess = true;
                    // Application.Run(new HomePage());
                    this.Close();
                }
                else
                {
                    lblLoginFailed.Visible = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
        }
    }
}
