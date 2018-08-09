using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket_wrapper sw;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
           // Thread th = new Thread(new ParameterizedThreadStart(mySocketReceive));
           // th.IsBackground = true;
           // th.Start(sw);
          
                   
            //string s= sw.socket_receive(buffer);
            

        }

        void mySocketReceive(object obj)
        {
            Socket_wrapper sw1 = obj as Socket_wrapper;
            byte[] buffer1 = new byte[1024 * 1024];
            string s = sw1.socket_receive(buffer1);
            //txtInfo.AppendText(s);
            dShowMsg d1 = new dShowMsg(showMsg);
            if (txtInfo.InvokeRequired)
            {
                txtInfo.Invoke(d1, s);
            }
            else 
            {
                txtInfo.AppendText(s);
            }

        }
  
  

        delegate void dShowMsg(object obj);
        void showMsg(object obj)
        {
            string s = obj as string;
            txtInfo.AppendText(s);
        }
        void ReceiveMsg()
        {
            while (true)
            {
                dShowMsg d1 = new dShowMsg(showMsg);
                try
                {
                    byte[] buffer = new byte[1024];
                    

                    int n= client.Receive(buffer);
                    string s = Encoding.UTF8.GetString(buffer, 0, n);
                   
                    this.Invoke(d1,(object)s);
                }
                catch(Exception ex)
                {
                    this.Invoke(d1, (object)ex.Message);
                    Thread.CurrentThread.Abort();
                    
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
            sw = new Socket_wrapper(txtIP.Text, int.Parse(txtPort.Text));

            sw.socket_send(txtMsg.Text);        
  /*
            if (client.Connected )
            {
                byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text);
                //client.BeginSend()
                client.Send(buffer);
                //
            }*/

        }


        private void connectSocket(IAsyncResult ar)
        {
         

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
            Thread.CurrentThread.Abort();
        }
    }
}
