using DevExpress.XtraGauges.Win.Gauges.Circular;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SerialPort port;
        WebClient client = new WebClient();
        DateTime now = DateTime.Now;
        String tempC = "0.00", tempK = "0.00", tempF = "0.00", humid = "0%", temp;
        String portName = null;
        int i = 0;
        String date;
        Boolean status = false;

        public Form1()
        {

            InitializeComponent();

        }

        public void splashScreen()
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iotDataSet.lab' table. You can move, or remove it, as needed.
            this.labTableAdapter.Fill(this.iotDataSet.lab);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
            btnRefrigOFF.Enabled = false;
            btnRefrigON.Enabled = false;
            port = new SerialPort();


            lblCel.Text = tempC;
            lblFaren.Text = tempF;
            lblHumid.Text = humid;
            lblKel.Text = tempK;

            getDate();
            lblDate.Text = date;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void flyoutPanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gaugeControl3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iotDataSet1.lab' table. You can move, or remove it, as needed.
            this.labTableAdapter.Fill(this.iotDataSet.lab);

            
            try
            {
                if (port.IsOpen)
                {
                    port.Write("3");
                    port.Write("CR+LF\r\n");
                    temp = port.ReadExisting();
                    //port.Write("2");
                    string[] words = temp.Split(';');
                    int i = 1;
                    foreach (string word in words)
                    {
                        switch (i)
                        {
                            case 1: humid = word;
                                i++;
                                break;
                            case 2: tempC = word;
                                i++;
                                break;
                            case 3: tempF = word;
                                i++;
                                break;
                            case 4: tempK = word;
                                i++;
                                break;
                        }
                    }
                    lblCel.Text = tempC;
                    lblHumid.Text = humid;
                    lblFaren.Text = tempF;
                    lblKel.Text = tempK;
                    insertDatabase();
                    hostData();

                }
                else
                {
                    MessageBox.Show("Oops!!! Couldn't Open SerialPort");
                }
            }
            catch (Exception exee)
            {
                MessageBox.Show("Error in opening port" + exee.Data);
            }
        }

        public void getDate()
        {
            switch (DateTime.Now.Month)
            {
                case 1: date = "January  ";
                    break;
                case 2: date = "February  ";
                    break;
                case 3: date = "March  ";
                    break;
                case 4: date = "April  ";
                    break;
                case 5: date = "May  ";
                    break;
                case 6: date = "June  ";
                    break;
                case 7: date = "Jaly  ";
                    break;
                case 8: date = "August  ";
                    break;
                case 9: date = "September  ";
                    break;
                case 10: date = "October  ";
                    break;
                case 11: date = "November  ";
                    break;
                case 12: date = "December  ";
                    break;

            }
            date += DateTime.Now.Day;
            date += "th  ";
            date += DateTime.Now.DayOfWeek.ToString();
            date += "  ";
            date += DateTime.Now.Year.ToString();
        }
        private void insertDatabase()
        {
            now = DateTime.Now;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\project\iot.accdb";

            con.Open();
           OleDbCommand cmd = new OleDbCommand("insert into [lab](tempC,tempK,tempF,humidity,record,dates) values(?,?,?,?,?,?)");
           
            cmd.Parameters.Add(new OleDbParameter("@tempC", tempC));
            cmd.Parameters.Add(new OleDbParameter("@tempK", tempK));
            cmd.Parameters.Add(new OleDbParameter("@tempF", tempF));
            cmd.Parameters.Add(new OleDbParameter("@humid", humid));
            cmd.Parameters.Add(new OleDbParameter("@record", DateTime.Now.ToString("h:mm:ss tt")));
            cmd.Parameters.Add(new OleDbParameter("@dates", DateTime.Now.Date.ToString()));

            cmd.Connection = con;
            /*
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = @"INSERT INTO [lab] (tempC)values (@tempC)";
             cmd.Parameters.AddWithValue("@tempC",tempC);
             */
            int i = 0;

            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void hostData()
        {
           // Console.WriteLine(status.ToString());
            
            now = DateTime.Now;
            try
            {
                NameValueCollection values = new NameValueCollection(){
                    {"temp",tempC},
                    {"humid",humid},
                    {"date",now.ToString()},
                    {"status",status.ToString()}
                };

                string pagesource = Encoding.UTF8.GetString(client.UploadValues("http://localhost/iotsharma/iot/add.php", values));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchPorts_Click(object sender, EventArgs e)
        {
            comboPorts.Enabled = true;
            String[] ports = SerialPort.GetPortNames();
            foreach (String p in ports)
                comboPorts.Items.Add(p);
        }

        private void comboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = comboPorts.Text;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                port.PortName = portName;
                port.BaudRate = 9600;
                port.Open();
                btnRefrigON.Enabled = true;
                timer1.Interval = 3000;
                timer1.Start();
                timer2.Interval = 3000;
                timer2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btnRefrigON_Click(object sender, EventArgs e)
        {
           // port.Write("1");
            port.WriteLine("1");
            port.Write("CR+LF\r\n");
        }

        private void btnRefrigOFF_Click(object sender, EventArgs e)
        {
            port.WriteLine("2");
         }

        private void btnRefrigON_Click_1(object sender, EventArgs e)
        {
            port.WriteLine("1");
            port.Write("CR+LF\r\n");
        }

        private void btnRefrigOFF_Click_1(object sender, EventArgs e)
        {
            port.WriteLine("2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.WriteLine("1");
                btnRefrigOFF.Enabled = true;
                btnRefrigON.Enabled = false;
            }
            else
                MessageBox.Show("Please Select COM PORT");
        }

        private void btnRefrigOFF_Click_2(object sender, EventArgs e)
        {

            if (port.IsOpen)
            {

                port.WriteLine("2");
                btnRefrigON.Enabled = true;
                btnRefrigOFF.Enabled = false;
            }
            else
                MessageBox.Show("Please Select COM PORT");
        }

        private void btnSearchPorts_Click_1(object sender, EventArgs e)
        {
            comboPorts.Enabled = true;
            String[] ports = SerialPort.GetPortNames();
            foreach (String p in ports)
                comboPorts.Items.Add(p);
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {

                port.PortName = portName;
                port.BaudRate = 9600;
                port.Open();
                btnRefrigON.Enabled = true;
                timer1.Interval = 3000;
                timer1.Start();
                timer2.Interval = 3000;
                timer2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void comboPorts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            portName = comboPorts.Text;
        }

        private void btnRefrigON_Click_2(object sender, EventArgs e)
        {
            turnONRefrig();
        }

        public void turnONRefrig()
        {
            if (port.IsOpen)
            {
                port.WriteLine("1");
                btnRefrigOFF.Enabled = true;
                btnRefrigON.Enabled = false;
                status = true;
            }
            else
                MessageBox.Show("Please Select COM PORT");
        }
        private void btnRefrigOFF_Click_3(object sender, EventArgs e)
        {
            turnOFFRefrig();  
        }
        public void turnOFFRefrig()
        {
            if (port.IsOpen)
            {

                port.WriteLine("2");
                btnRefrigON.Enabled = true;
                btnRefrigOFF.Enabled = false;
                status = false;
            }
            else
                MessageBox.Show("Please Select COM PORT");
        }
    }
}
