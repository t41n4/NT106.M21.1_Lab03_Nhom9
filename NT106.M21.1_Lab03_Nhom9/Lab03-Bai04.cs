using System;
using System.Threading;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
        }

        private void FormBai4_Load(object sender, EventArgs e)
        {
        }

        private void btnB4ChatServer_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThrd = new Thread(ServerThread);
            ServerThrd.Start();
            Thread isServerAliv = new Thread(() => isServerAlive(ServerThrd));
            isServerAliv.Start();
        }

        private void isServerAlive(Thread ServerThrd)
        {
            while (true)
            {
                if (ServerThrd.IsAlive)
                {
                    btnB4ChatServer.Enabled = false;
                }
                else
                {
                    btnB4ChatServer.Enabled = true;
                    break;
                }
            }
        }

        private void ServerThread()
        {
            Lab03_Bai04_ChatServer ChatServer = new Lab03_Bai04_ChatServer();
            ChatServer.ShowDialog();
        }

        private void btnB4ChatClient_Click(object sender, EventArgs e)
        {
            Thread ClientThrd = new Thread(ClientThread);
            ClientThrd.Start();
        }

        private void ClientThread()
        {
            Lab03_Bai04_ChatClient ChatClient = new Lab03_Bai04_ChatClient();
            ChatClient.ShowDialog();
        }
    }
}