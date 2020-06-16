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
        byte MSG_PUSH_1 = 0x01;
        byte MSG_PUSH_2 = 0x02;
        byte MSG_PUSH_3 = 0x03;
        byte MSG_PUSH_4 = 0x04;
        byte MSG_PUSH_5 = 0x05;
        byte MSG_OPEN_1 = 0x06;
        byte MSG_OPEN_2 = 0x07;
        byte MSG_OPEN_3 = 0x08;
        byte MSG_OPEN_4 = 0x09;
        byte MSG_OPEN_5 = 0x0a;
        byte MSG_CLOSE_1 = 0x0b;
        byte MSG_CLOSE_2 = 0x0c;
        byte MSG_CLOSE_3 = 0x0d;
        byte MSG_CLOSE_4 = 0x0e;
        byte MSG_CLOSE_5 = 0x0f;
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
            groupBox1.Enabled = (IsRightPort && serialPort1.IsOpen);
            groupBox2.Enabled = (IsRightPort && serialPort1.IsOpen);
            groupBox3.Enabled = (IsRightPort && serialPort1.IsOpen);
            groupBox4.Enabled = (IsRightPort && serialPort1.IsOpen);
            groupBox5.Enabled = (IsRightPort && serialPort1.IsOpen);
            groupBox5.Enabled = (IsRightPort && serialPort1.IsOpen);
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
            groupBox1.Text = ConfigurationManager.AppSettings["trigger1_Name"];
            groupBox1.Enabled = false;
            txtAngle1.Value = Convert.ToInt32(ConfigurationManager.AppSettings["trigger1_angel"]);
            
            groupBox2.Text = ConfigurationManager.AppSettings["trigger2_Name"];
            groupBox2.Enabled = false;
            txtAngle2.Value = Convert.ToInt32(ConfigurationManager.AppSettings["trigger2_angel"]);
            
            groupBox3.Text = ConfigurationManager.AppSettings["trigger3_Name"];
            groupBox3.Enabled = false;
            txtAngle3.Value = Convert.ToInt32(ConfigurationManager.AppSettings["trigger3_angel"]);

            groupBox4.Text = ConfigurationManager.AppSettings["trigger4_Name"];
            groupBox4.Enabled = false;
            txtAngle4.Value = Convert.ToInt32(ConfigurationManager.AppSettings["trigger4_angel"]);

            groupBox5.Text = ConfigurationManager.AppSettings["trigger5_Name"];
            groupBox5.Enabled = false;
            txtAngle5.Value = Convert.ToInt32(ConfigurationManager.AppSettings["trigger5_angel"]);

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

        private void btnPush1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int angle = Convert.ToInt32(txtAngle1.Value);
                SendMessage(Convert.ToByte(angle));
                SendMessage(MSG_PUSH_1);
            }
        }

        private void btnPush2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int angle = Convert.ToInt32(txtAngle2.Value);
                SendMessage(Convert.ToByte(angle));
                SendMessage(MSG_PUSH_2);
            }
        }

        private void btnPush3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int angle = Convert.ToInt32(txtAngle3.Value);
                SendMessage(Convert.ToByte(angle));
                SendMessage(MSG_PUSH_3);
            }
        }

        private void btnPush4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int angle = Convert.ToInt32(txtAngle4.Value);
                SendMessage(Convert.ToByte(angle));
                SendMessage(MSG_PUSH_4);
            }
        }

        private void btnPush5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int angle = Convert.ToInt32(txtAngle5.Value);
                SendMessage(Convert.ToByte(angle));
                SendMessage(MSG_PUSH_5);
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

        private void btnUsbClose1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_CLOSE_1);
            }
        }

        private void btnUsbOpen1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_OPEN_1);
            }
        }

        private void btnUsbOpen2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_OPEN_2);
            }
        }

        private void btnUsbOpen3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_OPEN_3);
            }
        }

        private void btnUsbOpen4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_OPEN_4);
            }
        }

        private void btnUsbOpen5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_OPEN_5);
            }
        }

        private void btnUsbClose2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_CLOSE_2);
            }
        }

        private void btnUsbClose3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_CLOSE_3);
            }
        }

        private void btnUsbClose4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_CLOSE_4);
            }
        }

        private void btnUsbClose5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendMessage(MSG_CLOSE_5);
            }
        }
    }
}
