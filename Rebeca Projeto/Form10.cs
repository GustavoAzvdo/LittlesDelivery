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
            this.Hide();
            Form8 form = new Form8();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form = new Form11();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form = new Form12();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form = new Form13();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 form = new Form14();
            form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 form = new Form15();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form = new Form9();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
