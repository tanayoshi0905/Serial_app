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

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox2.Text);
            textBox2.Text = string.Empty;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                disconnected.Checked = true;
                connectButton.Text = "接続";
            }
            else
            {
                try
                {
                    serialPort1.BaudRate = 19200;
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    connected.Checked = true;
                    connectButton.Text = "切断";

                }
                catch (Exception)
                {
                    disconnected.Checked = true;
                    //throw;
                }
            }
        }
    }
}
