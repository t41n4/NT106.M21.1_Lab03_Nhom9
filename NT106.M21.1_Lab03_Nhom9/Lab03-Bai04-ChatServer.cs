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

                    SendData("Đã kết nối thành công!!", clientSocket);
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
            while (true && clientSocket.Connected)
            {
                string text = "";
                bytesReceived = clientSocket.Receive(recv);
                text = ipepServer.ToString() + ": " + Encoding.UTF8.GetString(recv, 0, bytesReceived);
                listLog.Items.Add(new ListViewItem(text));
                broadcast(Encoding.UTF8.GetString(recv, 0, bytesReceived));
                if (text.Contains("Quit"))
                {
                    CloseClientConnection(clientSocket);
                }
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
            if (listenerSocket != null)
            {
                listenerSocket.Close();
                recv = null;
                bytesReceived = 0;
                ListClient = null;
                ipepServer = null;
                if (listLog.SelectedItems.Count == 0 && listLog.Items.Count != 0)
                {
                    listLog.Items[0].Selected = true;
                    listLog.Items.Clear();
                }

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
            CloseMe();
            btnB4Listen.Text = "Listen";
            btnB4Listen.Enabled = true;
        }

        private void listLog_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}