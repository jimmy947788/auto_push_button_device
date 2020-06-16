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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngle1 = new System.Windows.Forms.NumericUpDown();
            this.btnUsbOpen1 = new System.Windows.Forms.Button();
            this.btnUsbClose1 = new System.Windows.Forms.Button();
            this.btnPush1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAngle2 = new System.Windows.Forms.NumericUpDown();
            this.btnUsbOpen2 = new System.Windows.Forms.Button();
            this.btnUsbClose2 = new System.Windows.Forms.Button();
            this.btnPush2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAngle3 = new System.Windows.Forms.NumericUpDown();
            this.btnUsbOpen3 = new System.Windows.Forms.Button();
            this.btnUsbClose3 = new System.Windows.Forms.Button();
            this.btnPush3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngle4 = new System.Windows.Forms.NumericUpDown();
            this.btnUsbOpen4 = new System.Windows.Forms.Button();
            this.btnUsbClose4 = new System.Windows.Forms.Button();
            this.btnPush4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAngle5 = new System.Windows.Forms.NumericUpDown();
            this.btnUsbOpen5 = new System.Windows.Forms.Button();
            this.btnUsbClose5 = new System.Windows.Forms.Button();
            this.btnPush5 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle4)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle5)).BeginInit();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAngle1);
            this.groupBox1.Controls.Add(this.btnUsbOpen1);
            this.groupBox1.Controls.Add(this.btnUsbClose1);
            this.groupBox1.Controls.Add(this.btnPush1);
            this.groupBox1.Location = new System.Drawing.Point(14, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 81);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "齒輪角度:";
            // 
            // txtAngle1
            // 
            this.txtAngle1.Location = new System.Drawing.Point(68, 18);
            this.txtAngle1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtAngle1.Name = "txtAngle1";
            this.txtAngle1.Size = new System.Drawing.Size(78, 22);
            this.txtAngle1.TabIndex = 18;
            this.txtAngle1.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnUsbOpen1
            // 
            this.btnUsbOpen1.Location = new System.Drawing.Point(71, 46);
            this.btnUsbOpen1.Name = "btnUsbOpen1";
            this.btnUsbOpen1.Size = new System.Drawing.Size(75, 23);
            this.btnUsbOpen1.TabIndex = 17;
            this.btnUsbOpen1.Text = "斷開USB";
            this.btnUsbOpen1.UseVisualStyleBackColor = true;
            this.btnUsbOpen1.Click += new System.EventHandler(this.btnUsbOpen1_Click);
            // 
            // btnUsbClose1
            // 
            this.btnUsbClose1.Location = new System.Drawing.Point(152, 46);
            this.btnUsbClose1.Name = "btnUsbClose1";
            this.btnUsbClose1.Size = new System.Drawing.Size(75, 23);
            this.btnUsbClose1.TabIndex = 16;
            this.btnUsbClose1.Text = "連接USB";
            this.btnUsbClose1.UseVisualStyleBackColor = true;
            this.btnUsbClose1.Click += new System.EventHandler(this.btnUsbClose1_Click);
            // 
            // btnPush1
            // 
            this.btnPush1.Location = new System.Drawing.Point(152, 17);
            this.btnPush1.Name = "btnPush1";
            this.btnPush1.Size = new System.Drawing.Size(75, 23);
            this.btnPush1.TabIndex = 15;
            this.btnPush1.Text = "按下按鈕";
            this.btnPush1.UseVisualStyleBackColor = true;
            this.btnPush1.Click += new System.EventHandler(this.btnPush1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAngle2);
            this.groupBox2.Controls.Add(this.btnUsbOpen2);
            this.groupBox2.Controls.Add(this.btnUsbClose2);
            this.groupBox2.Controls.Add(this.btnPush2);
            this.groupBox2.Location = new System.Drawing.Point(14, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 81);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "齒輪角度:";
            // 
            // txtAngle2
            // 
            this.txtAngle2.Location = new System.Drawing.Point(68, 18);
            this.txtAngle2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtAngle2.Name = "txtAngle2";
            this.txtAngle2.Size = new System.Drawing.Size(78, 22);
            this.txtAngle2.TabIndex = 18;
            this.txtAngle2.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnUsbOpen2
            // 
            this.btnUsbOpen2.Location = new System.Drawing.Point(71, 46);
            this.btnUsbOpen2.Name = "btnUsbOpen2";
            this.btnUsbOpen2.Size = new System.Drawing.Size(75, 23);
            this.btnUsbOpen2.TabIndex = 17;
            this.btnUsbOpen2.Text = "斷開USB";
            this.btnUsbOpen2.UseVisualStyleBackColor = true;
            this.btnUsbOpen2.Click += new System.EventHandler(this.btnUsbOpen2_Click);
            // 
            // btnUsbClose2
            // 
            this.btnUsbClose2.Location = new System.Drawing.Point(152, 46);
            this.btnUsbClose2.Name = "btnUsbClose2";
            this.btnUsbClose2.Size = new System.Drawing.Size(75, 23);
            this.btnUsbClose2.TabIndex = 16;
            this.btnUsbClose2.Text = "連接USB";
            this.btnUsbClose2.UseVisualStyleBackColor = true;
            this.btnUsbClose2.Click += new System.EventHandler(this.btnUsbClose2_Click);
            // 
            // btnPush2
            // 
            this.btnPush2.Location = new System.Drawing.Point(152, 17);
            this.btnPush2.Name = "btnPush2";
            this.btnPush2.Size = new System.Drawing.Size(75, 23);
            this.btnPush2.TabIndex = 15;
            this.btnPush2.Text = "按下按鈕";
            this.btnPush2.UseVisualStyleBackColor = true;
            this.btnPush2.Click += new System.EventHandler(this.btnPush2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAngle3);
            this.groupBox3.Controls.Add(this.btnUsbOpen3);
            this.groupBox3.Controls.Add(this.btnUsbClose3);
            this.groupBox3.Controls.Add(this.btnPush3);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 81);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "齒輪角度:";
            // 
            // txtAngle3
            // 
            this.txtAngle3.Location = new System.Drawing.Point(68, 18);
            this.txtAngle3.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtAngle3.Name = "txtAngle3";
            this.txtAngle3.Size = new System.Drawing.Size(78, 22);
            this.txtAngle3.TabIndex = 18;
            this.txtAngle3.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnUsbOpen3
            // 
            this.btnUsbOpen3.Location = new System.Drawing.Point(71, 46);
            this.btnUsbOpen3.Name = "btnUsbOpen3";
            this.btnUsbOpen3.Size = new System.Drawing.Size(75, 23);
            this.btnUsbOpen3.TabIndex = 17;
            this.btnUsbOpen3.Text = "斷開USB";
            this.btnUsbOpen3.UseVisualStyleBackColor = true;
            this.btnUsbOpen3.Click += new System.EventHandler(this.btnUsbOpen3_Click);
            // 
            // btnUsbClose3
            // 
            this.btnUsbClose3.Location = new System.Drawing.Point(152, 46);
            this.btnUsbClose3.Name = "btnUsbClose3";
            this.btnUsbClose3.Size = new System.Drawing.Size(75, 23);
            this.btnUsbClose3.TabIndex = 16;
            this.btnUsbClose3.Text = "連接USB";
            this.btnUsbClose3.UseVisualStyleBackColor = true;
            this.btnUsbClose3.Click += new System.EventHandler(this.btnUsbClose3_Click);
            // 
            // btnPush3
            // 
            this.btnPush3.Location = new System.Drawing.Point(152, 17);
            this.btnPush3.Name = "btnPush3";
            this.btnPush3.Size = new System.Drawing.Size(75, 23);
            this.btnPush3.TabIndex = 15;
            this.btnPush3.Text = "按下按鈕";
            this.btnPush3.UseVisualStyleBackColor = true;
            this.btnPush3.Click += new System.EventHandler(this.btnPush3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtAngle4);
            this.groupBox4.Controls.Add(this.btnUsbOpen4);
            this.groupBox4.Controls.Add(this.btnUsbClose4);
            this.groupBox4.Controls.Add(this.btnPush4);
            this.groupBox4.Location = new System.Drawing.Point(14, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 81);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "齒輪角度:";
            // 
            // txtAngle4
            // 
            this.txtAngle4.Location = new System.Drawing.Point(68, 18);
            this.txtAngle4.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtAngle4.Name = "txtAngle4";
            this.txtAngle4.Size = new System.Drawing.Size(78, 22);
            this.txtAngle4.TabIndex = 18;
            this.txtAngle4.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnUsbOpen4
            // 
            this.btnUsbOpen4.Location = new System.Drawing.Point(71, 46);
            this.btnUsbOpen4.Name = "btnUsbOpen4";
            this.btnUsbOpen4.Size = new System.Drawing.Size(75, 23);
            this.btnUsbOpen4.TabIndex = 17;
            this.btnUsbOpen4.Text = "斷開USB";
            this.btnUsbOpen4.UseVisualStyleBackColor = true;
            this.btnUsbOpen4.Click += new System.EventHandler(this.btnUsbOpen4_Click);
            // 
            // btnUsbClose4
            // 
            this.btnUsbClose4.Location = new System.Drawing.Point(152, 46);
            this.btnUsbClose4.Name = "btnUsbClose4";
            this.btnUsbClose4.Size = new System.Drawing.Size(75, 23);
            this.btnUsbClose4.TabIndex = 16;
            this.btnUsbClose4.Text = "連接USB";
            this.btnUsbClose4.UseVisualStyleBackColor = true;
            this.btnUsbClose4.Click += new System.EventHandler(this.btnUsbClose4_Click);
            // 
            // btnPush4
            // 
            this.btnPush4.Location = new System.Drawing.Point(152, 17);
            this.btnPush4.Name = "btnPush4";
            this.btnPush4.Size = new System.Drawing.Size(75, 23);
            this.btnPush4.TabIndex = 15;
            this.btnPush4.Text = "按下按鈕";
            this.btnPush4.UseVisualStyleBackColor = true;
            this.btnPush4.Click += new System.EventHandler(this.btnPush4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtAngle5);
            this.groupBox5.Controls.Add(this.btnUsbOpen5);
            this.groupBox5.Controls.Add(this.btnUsbClose5);
            this.groupBox5.Controls.Add(this.btnPush5);
            this.groupBox5.Location = new System.Drawing.Point(12, 410);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 81);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "齒輪角度:";
            // 
            // txtAngle5
            // 
            this.txtAngle5.Location = new System.Drawing.Point(68, 18);
            this.txtAngle5.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtAngle5.Name = "txtAngle5";
            this.txtAngle5.Size = new System.Drawing.Size(78, 22);
            this.txtAngle5.TabIndex = 18;
            this.txtAngle5.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnUsbOpen5
            // 
            this.btnUsbOpen5.Location = new System.Drawing.Point(71, 46);
            this.btnUsbOpen5.Name = "btnUsbOpen5";
            this.btnUsbOpen5.Size = new System.Drawing.Size(75, 23);
            this.btnUsbOpen5.TabIndex = 17;
            this.btnUsbOpen5.Text = "斷開USB";
            this.btnUsbOpen5.UseVisualStyleBackColor = true;
            this.btnUsbOpen5.Click += new System.EventHandler(this.btnUsbOpen5_Click);
            // 
            // btnUsbClose5
            // 
            this.btnUsbClose5.Location = new System.Drawing.Point(152, 46);
            this.btnUsbClose5.Name = "btnUsbClose5";
            this.btnUsbClose5.Size = new System.Drawing.Size(75, 23);
            this.btnUsbClose5.TabIndex = 16;
            this.btnUsbClose5.Text = "連接USB";
            this.btnUsbClose5.UseVisualStyleBackColor = true;
            this.btnUsbClose5.Click += new System.EventHandler(this.btnUsbClose5_Click);
            // 
            // btnPush5
            // 
            this.btnPush5.Location = new System.Drawing.Point(152, 17);
            this.btnPush5.Name = "btnPush5";
            this.btnPush5.Size = new System.Drawing.Size(75, 23);
            this.btnPush5.TabIndex = 15;
            this.btnPush5.Text = "按下按鈕";
            this.btnPush5.UseVisualStyleBackColor = true;
            this.btnPush5.Click += new System.EventHandler(this.btnPush5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 522);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle4)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAngle5)).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsbOpen1;
        private System.Windows.Forms.Button btnUsbClose1;
        private System.Windows.Forms.Button btnPush1;
        private System.Windows.Forms.NumericUpDown txtAngle1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtAngle2;
        private System.Windows.Forms.Button btnUsbOpen2;
        private System.Windows.Forms.Button btnUsbClose2;
        private System.Windows.Forms.Button btnPush2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtAngle3;
        private System.Windows.Forms.Button btnUsbOpen3;
        private System.Windows.Forms.Button btnUsbClose3;
        private System.Windows.Forms.Button btnPush3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtAngle4;
        private System.Windows.Forms.Button btnUsbOpen4;
        private System.Windows.Forms.Button btnUsbClose4;
        private System.Windows.Forms.Button btnPush4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtAngle5;
        private System.Windows.Forms.Button btnUsbOpen5;
        private System.Windows.Forms.Button btnUsbClose5;
        private System.Windows.Forms.Button btnPush5;
    }
}

