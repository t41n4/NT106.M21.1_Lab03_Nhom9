using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class Lab03_Bai3_TcpClient : Form
    {
        TcpClient tcpClient;
        NetworkStream ns;
        public Lab03_Bai3_TcpClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            Byte[] data = Encoding.UTF8.GetBytes("Hello Server \r\n");
            ns.Write(data, 0, data.Length);
        }

        private void Lab03_Bai3_TcpClient_Load(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress,8080);
    
            tcpClient.Connect(ipEndPoint);
            ns = tcpClient.GetStream();
        }

        private void Lab03_Bai3_TcpClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Quit\n");
            ns.Write(data,0,data.Length);
            ns.Close();
            tcpClient.Close();
        }
    }
}