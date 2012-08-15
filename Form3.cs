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
    public partial class Form3 : Form
    {

        public bool verifica = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                verifica = true;
                Close();
            }
            else
            {
                MessageBox.Show("ERRO","VERIFICA A SENHA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
