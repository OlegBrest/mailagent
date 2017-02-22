using System;
using System.Collections;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OpenPop;
using OpenPop.Pop3;
using OpenPop.Mime;
using OpenPop.Common;
using System.Collections.Generic;

namespace mailagent
{
    public partial class Form1 : Form
    {
        Pop3Client client = new Pop3Client();
        List<OpenPop.Mime.Message> allMessages;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                btnConnect.Text = "Disconnect";
                // Connect to the server
                try
                {
                    client.Connect(txtServer.Text, Convert.ToInt32(txtPort.Text), SSL_bx.Checked);
                    txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 36. Server connected.\r\n\r\n");
                    txtLog.Update();
                    // Authenticate ourselves towards the server
                    try
                    {
                        client.Authenticate(txtUser.Text, txtPass.Text);
                        txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 49. Server Authenticated.\r\n\r\n");
                        txtLog.Update();

                        // Get the number of messages in the inbox
                        List<string> mssgs = client.GetMessageUids();
                        int messageCount = mssgs.Count;
                        txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 54.Total messages: " + messageCount.ToString() + "\r\n\r\n");
                        txtLog.Update();

                        // We want to download all messages
                        allMessages = new List<OpenPop.Mime.Message>(messageCount);

                        // Messages are numbered in the interval: [1, messageCount]
                        // Ergo: message numbers are 1-based.
                        // Most servers give the latest message the highest number
                        for (int i = messageCount; i > (messageCount - 10); i--)
                        {
                            OpenPop.Mime.Message curr_mssg = client.GetMessage(i);
                            allMessages.Add(curr_mssg);
                            this.mail_gridview.Rows.Add(curr_mssg.Headers.From.MailAddress.ToString(), (messageCount-i)); 
                        }
                        //                        client.Disconnect();
                        /*
                        foreach (OpenPop.Mime.Message msg in allMessages.ToArray())
                        {
                            txtLog.AppendText("����: " + msg.Headers.Date.ToString() + Environment.NewLine);
                            txtLog.AppendText("�����������: " + msg.Headers.From.MailAddress.ToString() + Environment.NewLine);
                            txtLog.AppendText("����: " + msg.Headers.Subject + Environment.NewLine);
                            string body = "";
                            if (msg.MessagePart.IsText) body = msg.MessagePart.GetBodyAsText();
                            if (msg.MessagePart.IsMultiPart)
                            {
                                List<MessagePart> parts = new List<MessagePart>();
                                parts = msg.MessagePart.MessageParts;
                                foreach (MessagePart msg_part in parts)
                                {
                                    if (msg_part.IsText) body += (msg_part.GetBodyAsText() + Environment.NewLine);    
                                }
                            }
                            txtLog.AppendText("���������: " + (body) + Environment.NewLine + Environment.NewLine);
                            txtLog.Update();
                        }
                            */
                    }
                    catch (Exception ex)
                    {
                        txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 71.Error: " + ex.Message + "\r\n\r\n");
                        txtLog.Update();
                        client.Disconnect();
                        btnConnect.Text = "Connect";
                        txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 73.Disconnected.\r\n\r\n");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 79.Error: " + ex.Message + "\r\n\r\n");
                    txtLog.Update();
                    btnConnect.Text = "Connect";
                    return;
                }
            }
            else
            {
                btnConnect.Text = "Connect";
                client.Disconnect();
                txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 89.Disconnected.\r\n\r\n");
            }
        }


        private void mssg_bttn_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                try
                {
                    client.SendCommand(this.mssg_txtbx.Text);
                    txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 101.Sending :  " + this.mssg_txtbx.Text + ".\r\n\r\n");
                    txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 102.Getting :  " + client.GetServerResponse() + ".\r\n\r\n");
                }
                catch (Exception ex)
                {
                    txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 106.ERROR :" + ex.Message + ".\r\n\r\n");
                }

            }
            else
            {
                txtLog.AppendText(DateTime.Now.ToLongTimeString() + " 112.No connection.\r\n\r\n");
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            this.txtLog.ScrollToCaret();
        }

        // view selected message
        private void mail_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {                    
            mail_mssg_txtbx.Text = "";
            OpenPop.Mime.Message msg = allMessages[(int)this.mail_gridview.Rows[e.RowIndex].Cells[mail_grid_column_ID.Index].Value];
            mail_mssg_txtbx.AppendText("����: " + msg.Headers.Date.ToString() + Environment.NewLine);
            mail_mssg_txtbx.AppendText("�����������: " + msg.Headers.From.MailAddress.ToString() + Environment.NewLine);
            mail_mssg_txtbx.AppendText("����: " + msg.Headers.Subject + Environment.NewLine);
            string body = "";
            string html = "";
            if (msg.MessagePart.IsText)
            {
                body = msg.MessagePart.GetBodyAsText();
            }
            if (msg.MessagePart.IsMultiPart)
            {
                List<MessagePart> parts = new List<MessagePart>();
                parts = msg.MessagePart.MessageParts;
                foreach (MessagePart msg_part in parts)
                {
                    if (msg_part.IsText) body += (msg_part.GetBodyAsText() + Environment.NewLine);
                }
            }

            // mssg reworking
            if (body.ToLower().Contains("<!DOCTYPE".ToLower()))
            {
                html = body.Substring(body.ToLower().IndexOf("<!DOCTYPE".ToLower()), body.Length - body.ToLower().IndexOf("<!DOCTYPE".ToLower()));
                body = body.Substring(0,body.Length - html.Length);
            }

            if ((body.ToLower().Contains("<style>".ToLower()))  && (html == ""))
            {
                html = body.Substring(body.ToLower().IndexOf("<style>".ToLower()), body.Length - body.ToLower().IndexOf("<style>".ToLower()));
                body = body.Substring(0, body.Length - html.Length);
            }
            if (html == "") html = body;
            mail_mssg_txtbx.AppendText("���������: " + (body) + Environment.NewLine + Environment.NewLine);
            mail_mssg_txtbx.Update();
            mail_web.DocumentText = html;
            mail_web.Update();
        }
    }
}