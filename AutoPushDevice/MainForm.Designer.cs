namespace AutoPushDevice
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ddlSerialPort = new System.Windows.Forms.ComboBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTrigger1 = new System.Windows.Forms.Button();
            this.btnTrigger2 = new System.Windows.Forms.Button();
            this.btnTrigger3 = new System.Windows.Forms.Button();
            this.btnTrigger4 = new System.Windows.Forms.Button();
            this.btnTrigger5 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ReadTimeout = 3000;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.WriteBufferSize = 4096;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "連線端口:";
            // 
            // ddlSerialPort
            // 
            this.ddlSerialPort.FormattingEnabled = true;
            this.ddlSerialPort.Location = new System.Drawing.Point(74, 6);
            this.ddlSerialPort.Name = "ddlSerialPort";
            this.ddlSerialPort.Size = new System.Drawing.Size(121, 20);
            this.ddlSerialPort.TabIndex = 1;
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(201, 4);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSerial.TabIndex = 2;
            this.btnOpenSerial.Text = "啟動連線";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.Location = new System.Drawing.Point(201, 33);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(75, 23);
            this.btnCloseSerial.TabIndex = 3;
            this.btnCloseSerial.Text = "關閉連線";
            this.btnCloseSerial.UseVisualStyleBackColor = true;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(287, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Serial:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            // 
            // btnTrigger1
            // 
            this.btnTrigger1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrigger1.Location = new System.Drawing.Point(12, 62);
            this.btnTrigger1.Name = "btnTrigger1";
            this.btnTrigger1.Size = new System.Drawing.Size(264, 67);
            this.btnTrigger1.TabIndex = 5;
            this.btnTrigger1.Text = "Trigger1";
            this.btnTrigger1.UseVisualStyleBackColor = true;
            this.btnTrigger1.Click += new System.EventHandler(this.btnTrigger1_Click);
            // 
            // btnTrigger2
            // 
            this.btnTrigger2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrigger2.Location = new System.Drawing.Point(12, 135);
            this.btnTrigger2.Name = "btnTrigger2";
            this.btnTrigger2.Size = new System.Drawing.Size(264, 67);
            this.btnTrigger2.TabIndex = 6;
            this.btnTrigger2.Text = "Trigger2";
            this.btnTrigger2.UseVisualStyleBackColor = true;
            this.btnTrigger2.Click += new System.EventHandler(this.btnTrigger2_Click);
            // 
            // btnTrigger3
            // 
            this.btnTrigger3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrigger3.Location = new System.Drawing.Point(12, 208);
            this.btnTrigger3.Name = "btnTrigger3";
            this.btnTrigger3.Size = new System.Drawing.Size(264, 67);
            this.btnTrigger3.TabIndex = 7;
            this.btnTrigger3.Text = "Trigger3";
            this.btnTrigger3.UseVisualStyleBackColor = true;
            this.btnTrigger3.Click += new System.EventHandler(this.btnTrigger3_Click);
            // 
            // btnTrigger4
            // 
            this.btnTrigger4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrigger4.Location = new System.Drawing.Point(12, 281);
            this.btnTrigger4.Name = "btnTrigger4";
            this.btnTrigger4.Size = new System.Drawing.Size(264, 67);
            this.btnTrigger4.TabIndex = 8;
            this.btnTrigger4.Text = "Trigger4";
            this.btnTrigger4.UseVisualStyleBackColor = true;
            this.btnTrigger4.Click += new System.EventHandler(this.btnTrigger4_Click);
            // 
            // btnTrigger5
            // 
            this.btnTrigger5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrigger5.Location = new System.Drawing.Point(14, 354);
            this.btnTrigger5.Name = "btnTrigger5";
            this.btnTrigger5.Size = new System.Drawing.Size(264, 67);
            this.btnTrigger5.TabIndex = 9;
            this.btnTrigger5.Text = "Trigger5";
            this.btnTrigger5.UseVisualStyleBackColor = true;
            this.btnTrigger5.Click += new System.EventHandler(this.btnTrigger5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 459);
            this.Controls.Add(this.btnTrigger5);
            this.Controls.Add(this.btnTrigger4);
            this.Controls.Add(this.btnTrigger3);
            this.Controls.Add(this.btnTrigger2);
            this.Controls.Add(this.btnTrigger1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCloseSerial);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.ddlSerialPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlSerialPort;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnTrigger1;
        private System.Windows.Forms.Button btnTrigger2;
        private System.Windows.Forms.Button btnTrigger3;
        private System.Windows.Forms.Button btnTrigger4;
        private System.Windows.Forms.Button btnTrigger5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

