using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebeca_Projeto
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
