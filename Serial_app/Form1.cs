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

namespace Serial_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialReload();
        }

        public void serialReload()
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void SerialPortReload_Click(object sender, EventArgs e)
        {
            serialReload();
        }
    }
}
