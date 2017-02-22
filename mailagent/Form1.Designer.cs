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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.mail_gridview = new System.Windows.Forms.DataGridView();
            this.mail_grid_column_message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_grid_column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mail_mssg_txtbx = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mail_web = new System.Windows.Forms.WebBrowser();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mail_gridview)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(288, 8);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "995";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(424, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(206, 20);
            this.txtPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "POP3 Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(424, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(208, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(80, 8);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(167, 20);
            this.txtServer.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(640, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 72);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
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
            this.SSL_bx.Location = new System.Drawing.Point(360, 8);
            this.SSL_bx.Name = "SSL_bx";
            this.SSL_bx.Size = new System.Drawing.Size(46, 17);
            this.SSL_bx.TabIndex = 5;
            this.SSL_bx.Text = "SSL";
            this.SSL_bx.UseVisualStyleBackColor = true;
            // 
            // mssg_txtbx
            // 
            this.mssg_txtbx.Location = new System.Drawing.Point(8, 32);
            this.mssg_txtbx.Multiline = true;
            this.mssg_txtbx.Name = "mssg_txtbx";
            this.mssg_txtbx.Size = new System.Drawing.Size(305, 48);
            this.mssg_txtbx.TabIndex = 7;
            this.mssg_txtbx.Text = "mssg to server";
            // 
            // mssg_bttn
            // 
            this.mssg_bttn.Location = new System.Drawing.Point(320, 32);
            this.mssg_bttn.Name = "mssg_bttn";
            this.mssg_bttn.Size = new System.Drawing.Size(85, 48);
            this.mssg_bttn.TabIndex = 8;
            this.mssg_bttn.Text = "Send";
            this.mssg_bttn.UseVisualStyleBackColor = true;
            this.mssg_bttn.Click += new System.EventHandler(this.mssg_bttn_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtPass);
            this.splitContainer3.Panel1.Controls.Add(this.SSL_bx);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.txtServer);
            this.splitContainer3.Panel1.Controls.Add(this.mssg_txtbx);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.mssg_bttn);
            this.splitContainer3.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer3.Panel1.Controls.Add(this.txtPort);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.txtUser);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1MinSize = 90;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Panel2MinSize = 150;
            this.splitContainer3.Size = new System.Drawing.Size(741, 572);
            this.splitContainer3.SplitterDistance = 90;
            this.splitContainer3.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(741, 478);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 13;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(741, 56);
            this.txtLog.TabIndex = 0;
            this.txtLog.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.mail_gridview);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(741, 418);
            this.splitContainer2.SplitterDistance = 187;
            this.splitContainer2.TabIndex = 0;
            // 
            // mail_gridview
            // 
            this.mail_gridview.AllowUserToAddRows = false;
            this.mail_gridview.AllowUserToDeleteRows = false;
            this.mail_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mail_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mail_grid_column_message,
            this.mail_grid_column_ID});
            this.mail_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mail_gridview.Location = new System.Drawing.Point(0, 0);
            this.mail_gridview.Name = "mail_gridview";
            this.mail_gridview.ReadOnly = true;
            this.mail_gridview.RowHeadersVisible = false;
            this.mail_gridview.Size = new System.Drawing.Size(187, 418);
            this.mail_gridview.TabIndex = 0;
            this.mail_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mail_gridview_CellClick);
            // 
            // mail_grid_column_message
            // 
            this.mail_grid_column_message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mail_grid_column_message.HeaderText = "Сообщение";
            this.mail_grid_column_message.Name = "mail_grid_column_message";
            this.mail_grid_column_message.ReadOnly = true;
            // 
            // mail_grid_column_ID
            // 
            this.mail_grid_column_ID.HeaderText = "ID";
            this.mail_grid_column_ID.Name = "mail_grid_column_ID";
            this.mail_grid_column_ID.ReadOnly = true;
            this.mail_grid_column_ID.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mail_mssg_txtbx);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Текст";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mail_mssg_txtbx
            // 
            this.mail_mssg_txtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mail_mssg_txtbx.Location = new System.Drawing.Point(3, 3);
            this.mail_mssg_txtbx.Multiline = true;
            this.mail_mssg_txtbx.Name = "mail_mssg_txtbx";
            this.mail_mssg_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mail_mssg_txtbx.Size = new System.Drawing.Size(536, 386);
            this.mail_mssg_txtbx.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mail_web);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HTML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mail_web
            // 
            this.mail_web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mail_web.Location = new System.Drawing.Point(3, 3);
            this.mail_web.MinimumSize = new System.Drawing.Size(20, 20);
            this.mail_web.Name = "mail_web";
            this.mail_web.Size = new System.Drawing.Size(536, 408);
            this.mail_web.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 572);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POP3Check";
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mail_gridview)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView mail_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_grid_column_message;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_grid_column_ID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox mail_mssg_txtbx;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser mail_web;
    }
}

