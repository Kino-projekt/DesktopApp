using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Forms;
using DesktopApp.Properties;

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
            LoginUserFromData();
            Application.Run(mainForm);
        }

        private static void LoginUserFromData()
        {
            string email = Settings.Default.Email;
            string password = Settings.Default.Password;
            if (email.Length > 3)
            {
                AuthData authData = new AuthData(email, password);
                ConnectionController connection = ConnectionControllerImpl.GetController();
                connection.Singin(authData);
            }
        }
    }
}
