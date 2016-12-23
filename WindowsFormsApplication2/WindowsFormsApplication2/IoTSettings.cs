using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication2
{
    public partial class IoTSettings : Form
    {
        string portName = "";
        OleDbConnection con;
        OleDbCommand cmd;
        public IoTSettings()
        {
            InitializeComponent();
        }

        private void IoTSettings_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            cmbPort.Enabled = false;

            displayPort();
        }
        public void displayPort()
        {
            con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\project\iot.accdb";

            //   cmd = new OleDbCommand("select port from settings",con);
            try
            {
                con.Open();
                cmd = new OleDbCommand(string.Format("SELECT * FROM settings"), con);

                OleDbDataReader reader = cmd.ExecuteReader();
                String str = "";

                if (reader.HasRows)
                {
                    while (reader.Read())
                        str = reader["port"].ToString();
                    lblPort.Text = str;
                    // Application.Run(new HomePage());

                }
                else
                {
                    lblPort.Text = "No Port has selected";
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbPort.Enabled = true;
            String[] ports = SerialPort.GetPortNames();
            foreach (String p in ports)
                cmbPort.Items.Add(p);
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = cmbPort.Text;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\project\iot.accdb";
            try
            {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("insert into [settings](port) values(?)");

                cmd1.Parameters.Add(new OleDbParameter("@port", portName));
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                con.Close();
                displayPort();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }
    }
}
