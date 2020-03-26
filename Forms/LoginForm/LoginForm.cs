using System;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.AccessServices.LoginServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.LoginForm
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            DesingerService desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
        }

        private void registractionButton_Click(object sender, EventArgs e)
        {
            Close();
            FormsController formsController = FormsControllerImpl.GetInstance();
            formsController.OpenRegitrationForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginService loginService = LoginServiceImpl.GetService();
            bool currectEmail = loginService.SetUserEmail(emailField.Text);
            if (!currectEmail)
                wrongEmailLabel.Visible = true;
            bool currectPassword = loginService.SetUserPassword(passwordField.Text);
            if (!currectPassword)
                wrongPasswordLabel.Visible = true;

            if (currectEmail && currectPassword)
            {
                if(loginService.LoginNewUser())
                    Close(); //registration form
            }
        }
    }
}
