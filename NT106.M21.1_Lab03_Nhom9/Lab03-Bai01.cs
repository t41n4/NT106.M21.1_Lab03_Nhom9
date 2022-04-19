using System;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, System.EventArgs e)
        {
            Lab03B1UDPServer server = new Lab03B1UDPServer();
            server.Show();
        }

        private void btnClient_Click(object sender, System.EventArgs e)
        {
            Lab3B1UDPClient udpclient = new Lab3B1UDPClient();
            udpclient.ShowDialog();
        }

        private void FormBai1_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}