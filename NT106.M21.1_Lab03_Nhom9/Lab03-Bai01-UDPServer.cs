using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class Lab03B1UDPServer : Form
    {
        private delegate void InfoMessageDel(String info);

        public Lab03B1UDPServer()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(int.Parse(ServerPortB1.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ": " +
                    returnData.ToString();
                InfoMessage(mess);
            }
        }

        public void InfoMessage(String info)
        {
            if (messagelist1.InvokeRequired)
            {
                InfoMessageDel method = new InfoMessageDel(InfoMessage);
                messagelist1.Invoke(method, new object[] { info });
                return;
            }
            messagelist1.Items.Add(info);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}