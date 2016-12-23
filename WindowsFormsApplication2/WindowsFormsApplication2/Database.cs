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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iotDataSet2.lab' table. You can move, or remove it, as needed.
            this.labTableAdapter.Fill(this.iotDataSet2.lab);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
