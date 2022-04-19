using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class Lab03_Bai04_ChatServer : Form
    {
        private byte[] recv;
        private int bytesReceived = 0;
        private List<Socket> ListClient;
        private Socket listenerSocket;
        private IPEndPoint ipepServer;

        public Lab03_Bai04_ChatServer()
        {
            InitializeComponent();
        }

        private void btnB4Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread StartListenThread = new Thread(ListenThread);
            StartListenThread.Start();
            btnB4Listen.Text = "Listenning...";
        }

        private void ListenThread()
        {
            bytesReceived = 0;
            recv = new byte[1024];
            listenerSocket = new Socket(
                 AddressFamily.InterNetwork,
                 SocketType.Stream,
                 ProtocolType.Tcp
                 );
            ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listLog.Items.Add(new ListViewItem("Listenning on: " + ipepServer.ToString()));
            listenerSocket.Listen(-1);
            AcceptClient();
        }

        private void AcceptClient()
        {
            try
            {
                ListClient = new List<Socket>();
                while (true)
                {
                    Socket clientSocket = listenerSocket.Accept();
                    ListClient.Add(clientSocket);
                    SendData("Message From Server: Hi, Welcome to My Room Chat!", clientSocket);
                    listLog.Items.Add(new ListViewItem("New Client Connected: " + clientSocket.RemoteEndPoint.ToString()));
                    Thread receiver = new Thread(() => ReceiveDataThread(clientSocket));
                    receiver.Start();
                }
            }
            catch (Exception)
            {
                CloseMe();
            }
        }

        private void ReceiveDataThread(Socket clientSocket)
        {
            try
            {
                while (true && clientSocket.Connected && listenerSocket.LocalEndPoint != null)
                {
                    string msg = "";
                    bytesReceived = clientSocket.Receive(recv);
                    msg =  Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    string listViewString = clientSocket.RemoteEndPoint.ToString() + ": " + msg;
                  
                    
                    listLog.Items.Add(new ListViewItem(listViewString));
                    broadcast(msg);
                    if (msg.Contains("quit"))
                    {
                        Thread.Sleep(1000);                
                        CloseClientConnection(clientSocket);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đóng kết nối!");
                this.Close();
            }
        }

        private void CloseClientConnection(Socket clientSocket)
        {
            clientSocket.Close();
            foreach (var item in ListClient.ToArray())
            {
                if (item == clientSocket)
                {
                    ListClient.RemoveAt(ListClient.IndexOf(item));
                }
            }
        }

        private void SendData(string msg, Socket client)
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(msg);
            client.Send(data);
        }

        private void broadcast(string msg)
        {
            foreach (var item in ListClient)
            {
                SendData(msg, item);
            }
        }

        private void CloseMe()
        {
            StopListening();

            foreach (var item in ListClient.ToArray())
            {
                CloseClientConnection(item);
            }

            ListClient.Clear();

            recv = null;
            bytesReceived = 0;
            ipepServer = null;
        }

        private void StopListening()
        {
            if (listenerSocket != null)
            {
                broadcast("server quit");

                if (listLog.SelectedItems.Count == 0 && listLog.Items.Count != 0)
                {
                    
                    listLog.Items.Clear();
                }
                
                listenerSocket.Close();
            }
        }

        private void Lab03_Bai04_ChatServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseMe();
        }

        private void Lab03_Bai04_ChatServer_Load(object sender, EventArgs e)
        {
            Thread ControlListenBtn = new Thread(ControlListenButton);
            ControlListenBtn.Start();
        }

        private void ControlListenButton()
        {
            while (true)
            {
                if (btnB4Listen.Text == "Listenning...")
                {
                    btnB4Listen.Enabled = false;
                    btnStop.Visible = true;
                }
                else btnStop.Visible = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopListening();
            btnB4Listen.Text = "Listen";
            btnB4Listen.Enabled = true;
        }
    }
}