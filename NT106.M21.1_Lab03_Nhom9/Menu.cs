using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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
            FormBai1 Bai2 = new FormBai1();
            Bai2.ShowDialog();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            FormBai1 Bai3 = new FormBai1();
            Bai3.ShowDialog();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            FormBai1 Bai4 = new FormBai1();
            Bai4.ShowDialog();
        }
    }
}
