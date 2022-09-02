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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 form = new Form18();
            form.Closed += (s, args) => this.Close();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuário.Text.Equals("Felipe") && txtSenha.Text.Equals("0"))

                {
                    this.Hide();
                    Form5 form = new Form5();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuário.Focus();
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário ou senha incorretos.",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            Form17 form = new Form17();
            form.Closed  += (s, args) => this.Close();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form3 form = new Form3();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}

