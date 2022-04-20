using System;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }

        private void OpenTCPServer_Click(object sender, EventArgs e)
        {
            Lab03_Bai3_TcpServer form = new Lab03_Bai3_TcpServer();
            form.Show();
        }

        private void OpenClient_Click(object sender, EventArgs e)
        {
            Lab03_Bai3_TcpClient form = new Lab03_Bai3_TcpClient();
            form.Show();
        }
    }
}