using System;
using System.Windows.Forms;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Services.AccessServices.LoginServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Backend.Services.SaveServices;
using DesktopApp.Forms.LoadForm;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.AccessForms.LoginForm
{
    public partial class LoginForm : MaterialForm
    {
        private LoginService loginService;
        public LoginForm()
        {
            InitializeComponent();
            DesingerService desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            loginService = LoginServiceImpl.GetService();
        }

        private void registractionButton_Click(object sender, EventArgs e)
        {
            Close();
            FormsController formsController = FormsControllerImpl.GetInstance();
            formsController.OpenRegitrationForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (CheckEmail() && CheckPassword())
            {
                Cursor.Current = Cursors.WaitCursor;
                SaveService.SetUserRemember(rememberMeButton.Checked);
                if (loginService.LoginNewUser())
                {
                    Visible = false;
                    LoadingForm loading = new LoadingForm();
                    loading.StartDownload(false);
                    Close();
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private bool CheckEmail()
        {
            string email = emailField.Text;
            if (loginService.SetUserEmail(email))
            {
                wrongEmailLabel.Visible = false;
                return true;
            }
            else
                wrongEmailLabel.Visible = true;

            return false;
        }

        private bool CheckPassword()
        {
            string password = passwordField.Text;
            if (loginService.SetUserPassword(password))
            {
                wrongPasswordLabel.Visible = false;
                return true;
            }
            else
                wrongPasswordLabel.Visible = true;

            return false;
        }
    }
}
