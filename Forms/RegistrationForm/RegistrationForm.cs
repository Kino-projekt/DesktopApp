using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.AccessControllers;
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.AccessServices.RegistrationServices;
using DesktopApp.Backend.Services.FormServices;
using DesktopApp.Backend.Services.UserServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.RegistrationForm
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Close();
            FormService formService = FormsController.GetFormService();
            formService.OpenLoginForm();
        }

        private void regitstrationButton_Click(object sender, EventArgs e)
        {
            RegistrationService registrationService = RegistrationController.GetRegistrationService();
            bool currectEmail = registrationService.SetUserEmail(emailField.Text);
            if (!currectEmail)
                wrongEmailLabel.Visible = true;
            bool currectPassword = registrationService.SetUserPassword(passwordField.Text);
            if (!currectPassword)
            {
                wrongPasswordLabel.Visible = true;
                passwordSizeLabel.Visible = true;
                passwordCharLabel.Visible = true;
            }

            if (currectEmail && currectPassword)
            {
                if(registrationService.RegisterNewUser())
                    Close(); //registration form
            }
        }
    }
}
