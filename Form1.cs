using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aula10_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Caixa_de_lista.Items.Remove (Caixa_de_lista.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string teste = textBox1.Text;
            Caixa_de_lista.Items.Add(AddDados.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair do programa?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }





    }
}
