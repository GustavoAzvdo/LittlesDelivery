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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Close();
        }
    }
}
