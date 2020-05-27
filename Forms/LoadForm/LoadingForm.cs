using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.AdminServices.ArticleServices;
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.AdminServices.MoviesServices;
using DesktopApp.Backend.Services.AdminServices.SeanceServices;
using DesktopApp.Backend.Services.AdminServices.UsersServices;
using DesktopApp.Backend.Services.DataServices.ArticleServices;
using DesktopApp.Backend.Services.DataServices.HallsServices;
using DesktopApp.Backend.Services.DataServices.MoviesServices;
using DesktopApp.Backend.Services.DataServices.SeanceServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.SaveServices;
using DesktopApp.Backend.Services.UserServices;
using DesktopApp.Properties;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.LoadForm
{
    public partial class LoadingForm : MaterialForm
    {
        private DesingerService desingerService;
        private MainForm.MainForm mainForm;

        private int MAX_PROGRESSBAR = 400;

        public LoadingForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(progressPanel);

            FormsController formsController = FormsControllerImpl.GetInstance();
            mainForm = formsController.GetMainForm();

        }

        public void StartDownload(bool programStart)
        {
            Show();
            mainForm.Visible = false;
            DownloadDataFromServer(programStart);
            mainForm.Visible = true;
            Close();
        }

        private void DownloadDataFromServer(bool programStart)
        {
            SetProgressBar(10);

            SetText("Pobieranie ogłoszeń...");
            ArticleServiceImpl.GetService();
            SetProgressBar(20);

            SetText("Pobieranie listy filmów...");
            MoviesServiceImpl.GetService();
            SetProgressBar(40);

            SetText("Pobieranie listy sal kinowych...");
            HallsServiceImpl.GetService();
            SetProgressBar(60);

            SetText("Pobieranie listy seansów...");
            SeanceServiceImpl.GetService();
            SetProgressBar(80);

            SetText("Sprawdzanie konta użytkownika...");
            if(programStart==true)
                LoginUserFromData();
            SetProgressBar(100);

            UserService userService = UserServiceImpl.GetInstance();
            Role role = userService.GetUserRole();
            if (role == Role.CUSTOMER)
                DownloadDataForCustomer();
            else if (role== Role.ADMIN)
            {
                DownloadDataForCustomer();
                DownloadDataForAdmin();
            }
        }

        private void DownloadDataForCustomer()
        {

        }

        private void DownloadDataForAdmin()
        {
            SetProgressBar(10);

            SetText("Pobieranie listy ogłoszeń dla adminstratora...");
            ArticleAdminServiceImpl.GetService();
            SetProgressBar(20);

            SetText("Pobieranie listy filmów dla administratora...");
            MoviesAdminServiceImpl.GetService();
            SetProgressBar(40);

            SetText("Pobieranie listy seansów dla administratora...");
            SeanceAdminServiceImpl.GetService();
            SetProgressBar(60);

            SetText("Pobieranie listy sal dla administratora...");
            HallsAdminServiceImpl.GetService();
            SetProgressBar(80);

            SetText("Pobieranie listy użytkowników dla administratora...");
            UsersServiceImpl.GetService();
            SetProgressBar(100);
        }

        private void SetProgressBar(int percent)
        {
            int width;
            if (percent > 0 && percent <= 100)
            {
                if (percent == 100)
                    width = MAX_PROGRESSBAR;
                else
                    width = percent*4;

                progressPanel.Size = new Size(width, progressPanel.Size.Height);
            }
        }

        private void SetText(string text)
        {
            textLabel.Text = text;
        }

        private static void LoginUserFromData()
        {
            string email = Settings.Default.Email;
            string password = Settings.Default.Password;
            if (email.Length > 3)
            {
                ConnectionController connection = ConnectionControllerImpl.GetController();
                connection.Singin(SaveService.GetUser());
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
