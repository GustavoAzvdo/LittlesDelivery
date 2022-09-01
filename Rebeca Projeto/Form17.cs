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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Senha enviada para o e-mail cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
                    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=6GfqT-HKsY8");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
