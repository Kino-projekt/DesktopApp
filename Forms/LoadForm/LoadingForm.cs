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
using DesktopApp.Backend.Services.AdminServices.UsersServices;
using DesktopApp.Backend.Services.DataServices.ArticleServices;
using DesktopApp.Backend.Services.DataServices.MoviesServices;
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

        //private int MAX_PROGRESSBAR = 400;

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
            SetText("Pobieranie ogłoszeń");
            ArticleService articleService = ArticleServiceImpl.GetService();

            SetText("Pobieranie listy filmów");
            MoviesService moviesService = MoviesServiceImpl.GetService();

            SetText("Sprawdzanie konta użytkownika");
            if(programStart==true)
                LoginUserFromData();

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
            SetText("Pobieranie listy ogłoszeń dla adminstratora");
            ArticleAdminService articleAdmin = ArticleAdminServiceImpl.GetService();

            SetText("Pobieranie listy uzytkowników dla administratora");
            UsersService usersService = UsersServiceImpl.GetService();
        }

        private void SetProgressBar(int i)
        {
            
            
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
    }
}
