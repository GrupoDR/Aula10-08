using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula10_08
{

    

    public partial class Form2 : Form
    {
        public bool Pbar = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 20;

            }
            else
            {
                //timer1.Enabled = false;
                timer1.Stop();

                Pbar = true;
                
                this.Dispose();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
