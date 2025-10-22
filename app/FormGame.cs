using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            FormDon f = new FormDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            FormDa f = new FormDa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBangxephang_Click(object sender, EventArgs e)
        {
            Bangxephang frm = new Bangxephang();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
