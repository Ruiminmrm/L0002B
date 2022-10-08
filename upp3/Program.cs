using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ruimin Ma, ruimac-1@student.ltu.se, L0002B, Uppgift 3
//Jinting Zhang, jinzha-2@student.ltu.se, L0002B, Uppgift 3
namespace WinFormsApp2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application1.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
