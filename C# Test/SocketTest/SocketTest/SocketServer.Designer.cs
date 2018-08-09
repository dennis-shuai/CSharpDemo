namespace SocketTest
{
    partial class fSocketServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RecievedList = new System.Windows.Forms.ListBox();
            this.ExecuteList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SendList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecievedList
            // 
            this.RecievedList.FormattingEnabled = true;
            this.RecievedList.ItemHeight = 12;
            this.RecievedList.Location = new System.Drawing.Point(29, 128);
            this.RecievedList.Name = "RecievedList";
            this.RecievedList.Size = new System.Drawing.Size(420, 88);
            this.RecievedList.TabIndex = 0;
            this.RecievedList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ExecuteList
            // 
            this.ExecuteList.FormattingEnabled = true;
            this.ExecuteList.ItemHeight = 12;
            this.ExecuteList.Location = new System.Drawing.Point(29, 249);
            this.ExecuteList.Name = "ExecuteList";
            this.ExecuteList.Size = new System.Drawing.Size(420, 88);
            this.ExecuteList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recieved Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Execute Status";
            // 
            // SendList
            // 
            this.SendList.FormattingEnabled = true;
            this.SendList.ItemHeight = 12;
            this.SendList.Location = new System.Drawing.Point(29, 371);
            this.SendList.Name = "SendList";
            this.SendList.Size = new System.Drawing.Size(420, 88);
            this.SendList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Send Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prestige", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(163, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Socket Server";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(514, 315);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(105, 88);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SendMessage";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(50, 70);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 8;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(227, 70);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "2001";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(29, 79);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(15, 12);
            this.IP.TabIndex = 10;
            this.IP.Text = "IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(197, 78);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(24, 12);
            this.lblPort.TabIndex = 11;
            this.lblPort.Text = "Port";
            // 
            // fSocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 460);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SendList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExecuteList);
            this.Controls.Add(this.RecievedList);
            this.Name = "fSocketServer";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fSocketServer_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RecievedList;
        private System.Windows.Forms.ListBox ExecuteList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox SendList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label lblPort;
    }
}

