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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função cadastrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
