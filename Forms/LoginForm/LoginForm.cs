using System;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.AccessControllers;
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.AccessServices.LoginServices;
using DesktopApp.Backend.Services.FormServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.LoginForm
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void registractionButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormService formService = FormsController.GetFormService();
            formService.OpenRegitrationForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginService loginService = LoginController.GetLoginService();
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
