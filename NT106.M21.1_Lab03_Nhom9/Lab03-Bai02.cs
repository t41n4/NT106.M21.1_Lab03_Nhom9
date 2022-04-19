using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, System.EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread severthread = new Thread(new ThreadStart(StartThread));
            severthread.Start();
        }

        private void StartThread()
        {
            listview.Items.Add(new ListViewItem("Waiting for connetion"));
            int bytesRecv = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;

            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepSV = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepSV);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            listview.Items.Add(new ListViewItem("New client conneted"));

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesRecv = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');
                listview.Items.Add(new ListViewItem("You said: " + text));
            }
            listenerSocket.Close();
        }
    }
}