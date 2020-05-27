using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace AutoPushDevice
{
    //https://www.thingiverse.com/thing:4171351
    public partial class MainForm : Form
    {
        byte MSG_DEVICE_INFO = 0x00;
        byte MSG_TRIGGER_1 = 0x01;
        byte MSG_TRIGGER_2 = 0x02;
        byte MSG_TRIGGER_3 = 0x03;
        byte MSG_TRIGGER_4 = 0x04;
        byte MSG_TRIGGER_5 = 0x05;
        bool IsRightPort = true;

        public MainForm()
        {
            InitializeComponent();
            serialPort1.Encoding = Encoding.ASCII;
        }

        void UpdateStatus()
        {
            toolStripStatusLabel1.Text = string.Format("Serial:{0}", ddlSerialPort.SelectedItem);
            toolStripStatusLabel2.Text = string.Format("Status:{0}", (serialPort1.IsOpen ? "Open" : "Close"));
            btnTrigger1.Enabled = (IsRightPort && serialPort1.IsOpen);
            btnTrigger2.Enabled = (IsRightPort && serialPort1.IsOpen);
            btnTrigger3.Enabled = (IsRightPort && serialPort1.IsOpen);
            btnTrigger4.Enabled = (IsRightPort && serialPort1.IsOpen);
            btnTrigger5.Enabled = (IsRightPort && serialPort1.IsOpen);
            btnOpenSerial.Enabled = !serialPort1.IsOpen;
            btnCloseSerial.Enabled = serialPort1.IsOpen;
        }

        void SendMessage(byte message)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(new byte[] { message }, 0, 1);
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message, "自動按鈕裝置", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnTrigger1.Text = ConfigurationManager.AppSettings["trigger1_Name"];
            btnTrigger1.Enabled = false;
            btnTrigger2.Text = ConfigurationManager.AppSettings["trigger2_Name"];
            btnTrigger2.Enabled = false;
            btnTrigger3.Text = ConfigurationManager.AppSettings["trigger3_Name"];
            btnTrigger3.Enabled = false;
            btnTrigger4.Text = ConfigurationManager.AppSettings["trigger4_Name"];
            btnTrigger4.Enabled = false;
            btnTrigger5.Text = ConfigurationManager.AppSettings["trigger5_Name"];
            btnTrigger5.Enabled = false;

            ddlSerialPort.DataSource = SerialPort.GetPortNames();
            UpdateStatus();
        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = ddlSerialPort.SelectedItem.ToString();
            serialPort1.Open();

            SendMessage(MSG_DEVICE_INFO);      

            UpdateStatus();
        }

        private void btnCloseSerial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) { 
                serialPort1.Close();
            }
            UpdateStatus();
        }

        private void btnTrigger1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_TRIGGER_1);
            }
        }

        private void btnTrigger2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_TRIGGER_2);
            }
        }

        private void btnTrigger3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_TRIGGER_3);
            }
        }

        private void btnTrigger4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_TRIGGER_4);
            }
        }

        private void btnTrigger5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_TRIGGER_5);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var buffer = serialPort1.ReadExisting();
            Debug.WriteLine("===>" + buffer);
            /*
            dynamic d = JObject.Parse(buffer);
            var msg = (byte)d.msg;
            if (msg == MSG_DEVICE_INFO)
            {
                IsRightPort = true;
            }
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                UpdateStatus();
            });*/
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
