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
    public partial class FormDa : Form
    {
        public FormDa()
        {
            InitializeComponent();
        }

        private void FormDa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
