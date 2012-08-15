using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace aula10_08
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form3 obj = new Form3();

            obj.ShowDialog();

            if (obj.verifica)
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
