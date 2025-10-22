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
    public partial class FormDon : Form
    {
        public FormDon()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 menuForm = new Form1();
            menuForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
        
        }
    }
}
