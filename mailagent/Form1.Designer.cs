namespace mailagent
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SSL_bx = new System.Windows.Forms.CheckBox();
            this.mssg_txtbx = new System.Windows.Forms.TextBox();
            this.mssg_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 147);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(427, 423);
            this.txtLog.TabIndex = 0;
            this.txtLog.TabStop = false;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(298, 10);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "995";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(298, 36);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(115, 20);
            this.txtPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "POP3 Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(90, 36);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(125, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(90, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(125, 20);
            this.txtServer.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(328, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Log:";
            // 
            // SSL_bx
            // 
            this.SSL_bx.AutoSize = true;
            this.SSL_bx.Checked = true;
            this.SSL_bx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SSL_bx.Location = new System.Drawing.Point(362, 10);
            this.SSL_bx.Name = "SSL_bx";
            this.SSL_bx.Size = new System.Drawing.Size(46, 17);
            this.SSL_bx.TabIndex = 5;
            this.SSL_bx.Text = "SSL";
            this.SSL_bx.UseVisualStyleBackColor = true;
            // 
            // mssg_txtbx
            // 
            this.mssg_txtbx.Location = new System.Drawing.Point(15, 62);
            this.mssg_txtbx.Multiline = true;
            this.mssg_txtbx.Name = "mssg_txtbx";
            this.mssg_txtbx.Size = new System.Drawing.Size(299, 54);
            this.mssg_txtbx.TabIndex = 7;
            this.mssg_txtbx.Text = "mssg to send";
            // 
            // mssg_bttn
            // 
            this.mssg_bttn.Location = new System.Drawing.Point(328, 96);
            this.mssg_bttn.Name = "mssg_bttn";
            this.mssg_bttn.Size = new System.Drawing.Size(85, 28);
            this.mssg_bttn.TabIndex = 8;
            this.mssg_bttn.Text = "Send";
            this.mssg_bttn.UseVisualStyleBackColor = true;
            this.mssg_bttn.Click += new System.EventHandler(this.mssg_bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 570);
            this.Controls.Add(this.mssg_bttn);
            this.Controls.Add(this.mssg_txtbx);
            this.Controls.Add(this.SSL_bx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "POP3Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox SSL_bx;
        private System.Windows.Forms.TextBox mssg_txtbx;
        private System.Windows.Forms.Button mssg_bttn;
    }
}

