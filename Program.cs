using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers;
using DesktopApp.Forms;

namespace DesktopApp
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm.MainForm mainForm = FormsController.GetFormService().GetMainForm();
            Application.Run(mainForm);
        }
    }
}
