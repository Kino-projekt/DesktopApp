using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
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

            FormsController formsController = FormsControllerImpl.GetInstance();
            MainForm.MainForm mainForm = formsController.GetMainForm();
            Application.Run(mainForm);
        }
    }
}
