using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace SocketTest
{
    public partial class fSocketServer : Form
    {
        public fSocketServer()
        {
            InitializeComponent();
        }
        Socket isock;
        Thread acceptThread;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sockAccept(Object obj)
        {
            Socket isock = (Socket)obj;
            isock.Accept();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            RecievedList.Text = "";
            SendList.Text = "";
            ExecuteList.Text = "";
            IPAddress IPaddr =  IPAddress.Parse(txtIP.Text);

            IPEndPoint ipep = new IPEndPoint(IPaddr, int.Parse(txtPort.Text));

            isock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            isock.Bind(ipep);
            ExecuteList.Items.Add("Server Bind IP:");

            isock.Listen(10);

            ExecuteList.Items.Add("Server Listen");

    
            acceptThread = new Thread(new ParameterizedThreadStart(AcceptInfo));
            acceptThread.IsBackground = true;
            acceptThread.Start(isock);

            //isock.Close();


        }
        delegate void dsetText(object obj);
        private void setText(object obj)
        {
            string s = obj as string;
            ExecuteList.Items.Add(s);
        }
        void AcceptInfo(Object obj)
        {
            Socket socket = obj as Socket;

            //byte[] data = new byte[1024];
            dsetText d1 = new dsetText(setText);
            while (true)
            {
              
                try
                {
                    Socket client = socket.Accept();
                    IPEndPoint clientip = (IPEndPoint)client.RemoteEndPoint;
                    string msg = "Connect With client : " + clientip.Address + " Port" + clientip.Port +"\r\n";

                    if (ExecuteList.InvokeRequired)
                    {
                        ExecuteList.Invoke(d1, msg);
                    }else
                    {
                        ExecuteList.Items.Add(msg);
                    }
                   
                    /* string welcome = "welcome here!";
                     data = Encoding.ASCII.GetBytes(welcome);
                     client.Send(data, data.Length, SocketFlags.None);
                    
                     data = new byte[1024];
                     recv = client.Receive(data);
                     RecievedList.Items.Add(Encoding.ASCII.GetString(data, 0, recv));
                     if (recv == 0) break;
                     client.Send(data, recv, SocketFlags.None);
                     */
                    if (client != null)
                    {
                        Thread RecieveMsgThread = new Thread(new ParameterizedThreadStart(recieveMessage));
                        RecieveMsgThread.IsBackground =true;
                        RecieveMsgThread.Start(client);
                    }
      

                }
                catch (Exception ex)
                {
                    if (ExecuteList.InvokeRequired)
                    {
                        ExecuteList.Invoke(d1, ex.Message);
                    }else
                    {
                        ExecuteList.Items.Add(ex.Message);
                    }
                    Thread.CurrentThread.Abort();
                    break;
                }
            }
        }
        void recieveMessage(object obj)
        {
            Socket client = obj as Socket;
            if (client != null)
            {
                dsetText d1 = new dsetText(setText);
                while (client != null)
                {
                    try
                    {
                        byte[] data = new byte[1024 * 1024];
                        int recv;
                        recv = client.Receive(data);

                        string revstring  = Encoding.ASCII.GetString(data, 0, recv);
                        this.Invoke(d1,  revstring);
                        string sendString = "hello "+((IPEndPoint)client.RemoteEndPoint).Address.ToString() + ",I get Message " +revstring;
                        data = Encoding.UTF8.GetBytes(sendString);
                        recv = data.Length;
                        client.Send(data, recv, SocketFlags.None);

                    }
                    catch (Exception ex)
                    {
                        if (ExecuteList.InvokeRequired)
                        {
                            ExecuteList.Invoke(d1, ex.Message);
                        }
                        else
                        {
                            ExecuteList.Items.Add(ex.Message);
                        }
                        Thread.CurrentThread.Abort();
                    }

                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
        }

        private void fSocketServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isock != null)
            {
                //isock.Shutdown(SocketShutdown.Both);
                //isock.Disconnect(true);
                isock.Close();
            }
            //if (acceptThread !=null &&acceptThread.ThreadState == ThreadState.Running)
                // acceptThread.Abort();
        }
               
         
    }
}
