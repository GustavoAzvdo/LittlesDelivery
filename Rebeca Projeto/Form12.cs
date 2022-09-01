using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rebeca_Projeto
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10(); 
            form.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Produto adicionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja realmente alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
            this.Close();
        }
    }
}
