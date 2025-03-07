namespace Serial_app
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SerialPortReload = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disconnected = new System.Windows.Forms.RadioButton();
            this.connected = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPortReload
            // 
            this.SerialPortReload.Location = new System.Drawing.Point(132, 46);
            this.SerialPortReload.Name = "SerialPortReload";
            this.SerialPortReload.Size = new System.Drawing.Size(75, 23);
            this.SerialPortReload.TabIndex = 0;
            this.SerialPortReload.Text = "再読み込み";
            this.SerialPortReload.UseVisualStyleBackColor = true;
            this.SerialPortReload.Click += new System.EventHandler(this.SerialPortReload_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disconnected);
            this.panel1.Controls.Add(this.connected);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(224, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 32);
            this.panel1.TabIndex = 2;
            // 
            // disconnected
            // 
            this.disconnected.AutoSize = true;
            this.disconnected.Location = new System.Drawing.Point(101, 6);
            this.disconnected.Name = "disconnected";
            this.disconnected.Size = new System.Drawing.Size(47, 16);
            this.disconnected.TabIndex = 1;
            this.disconnected.TabStop = true;
            this.disconnected.Text = "切断";
            this.disconnected.UseVisualStyleBackColor = true;
            // 
            // connected
            // 
            this.connected.AutoSize = true;
            this.connected.Location = new System.Drawing.Point(0, 6);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(47, 16);
            this.connected.TabIndex = 0;
            this.connected.TabStop = true;
            this.connected.Text = "接続";
            this.connected.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(362, 306);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 419);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 19);
            this.textBox2.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(337, 415);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(41, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "送信";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 73);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(195, 23);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "接続";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SerialPortReload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SerialPortReload;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton disconnected;
        private System.Windows.Forms.RadioButton connected;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button connectButton;
    }
}

