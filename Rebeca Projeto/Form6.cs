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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja limpar todos os dados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox12.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {


                this.Hide();
                Form7 form = new Form7();
                form.Closed += (s, args) => this.Close();
                form.Show();


            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido adicionado com sucesso !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox12.Text  +=   comboBox1.Text+"\r\n";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deseja alterar o pedido?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda criada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}

