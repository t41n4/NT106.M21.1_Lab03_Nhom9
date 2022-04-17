using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class Lab03_Bai04_ChatClient : Form
    {
        private TcpClient tcpClient;
        private NetworkStream ns;
        private IPEndPoint ipEndPoint;
        private Thread UpdateUI;

        public Lab03_Bai04_ChatClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            if (!LeaveYourName())
            {
                return;
            }
            SendData(tbMessage.Text);
        }

        private bool NewClient()
        {
            try
            {
                //1 Tạo đối tượng TcpClient
                tcpClient = new TcpClient();
                //2 Kết nối đến Server với 1 địa chỉ Ip và Port xác định
                ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                tcpClient.Connect(ipEndPoint);
                Thread Receiver = new Thread(ReceiveFromSever);
                Receiver.Start();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tcpClient = null;
                ipEndPoint = null;
                this.Close();
                return false;
            }
        }

        private void ReceiveFromSever()
        {
            //thiet lap ket noi de nhan du lieu tu server
            try
            {
                byte[] recv = new byte[1024];
                while (true)
                {
                    string text = "";
                    int bytesReceived = tcpClient.Client.Receive(recv);
                    text = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    UpdateUI = new Thread(() => UpdateUIThread(text));
                    UpdateUI.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Client Đóng kết nối!");
                this.Close();
            }
        }

        private void UpdateUIThread(string text)
        {
            listLog.Items.Add(new ListViewItem(text));
        }

        private void SendData(string msg)
        {
            //3 Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
            ns = tcpClient.GetStream();
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(tbClientName.Text + ": " + msg);
            ns.Write(data, 0, data.Length);
        }
        private bool LeaveYourName()
        {
            if (String.IsNullOrEmpty(tbClientName.Text))
            {
                MessageBox.Show("Leave Your Name Before do Anything!");
                return false;
                
            }
            return true;
        }
        private bool CloseClient()
        {
            try
            {
                if (tcpClient != null)
                {
                    if (!LeaveYourName()) { return false; }
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(tbClientName.Text + ": quit");
                    ns = tcpClient.GetStream();
                    ns.Write(data, 0, data.Length);
                    ns.Close();
                    tcpClient.Close();
                    return true;
                }
                return true;
      
            }
            catch (Exception)
            {
                this.Close();
                return true;
            }
            //5 Dùng phương thức Write để gửi dữ liệu mang dấu hiệu kết thúc cho Server
            // biết và đóng kết nối
        }

        private void Lab03_Bai04_ChatClient_Load(object sender, System.EventArgs e)
        {
            if (!NewClient()) this.Close();
            
        }

        private void Lab03_Bai04_ChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseClient())
            {
                e.Cancel = true;
            }
        }
    }
}