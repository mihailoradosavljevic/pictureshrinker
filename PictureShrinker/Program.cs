using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

           
                Application.Run(new Form1());
            
            
               // MessageBox.Show("E PA NISI ODABRAO JPG SLIKU SAMO TO JE DOZVOLJENO");
              //  Application.Restart();

          
        }
    }
}
