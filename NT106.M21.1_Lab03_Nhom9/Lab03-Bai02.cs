using System.Windows.Forms;

namespace NT106.M21._1_Lab03_Nhom9
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}