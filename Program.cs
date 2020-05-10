using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.SaveServices;
using DesktopApp.Forms;
using DesktopApp.Forms.LoadForm;
using DesktopApp.Forms.Notification;
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
            if (CheckInternet() == false)
            {
                DialogResult dialog = dialog = MessageBox.Show("Błąd połączenia z internetem! Połączenie internetowe jest niezbędne do uruchomienia tego programu. W celu ustalenia problemów z łączem internetowym skontaktuj się ze swoim dostawcą internetowym w celu wykrycia przyczyny awarii.", "Scruter", MessageBoxButtons.OK);
                Application.Exit();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormsController formsController = FormsControllerImpl.GetInstance();
            MainForm.MainForm mainForm = formsController.GetMainForm();

            LoadingForm loadingForm = new LoadingForm();
            loadingForm.StartDownload(true);

            Application.Run(mainForm);
            
        }

        private static bool CheckInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
