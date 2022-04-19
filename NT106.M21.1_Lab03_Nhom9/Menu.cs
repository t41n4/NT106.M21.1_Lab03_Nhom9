using System;
using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            FormBai1 Bai1 = new FormBai1();
            Bai1.ShowDialog();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            FormBai2 Bai2 = new FormBai2();
            Bai2.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            FormBai3 form = new FormBai3();
            form.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            FormBai4 Bai4 = new FormBai4();
            Bai4.ShowDialog();
        }
    }
}