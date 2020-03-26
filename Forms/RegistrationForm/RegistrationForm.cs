using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.AccessServices.RegistrationServices;
using DesktopApp.Backend.Services.DesingerServices;
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
            DesingerService desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Close();
            FormsController formsController = FormsControllerImpl.GetInstance();
            formsController.OpenLoginForm();
        }

        private void regitstrationButton_Click(object sender, EventArgs e)
        {
            RegistrationService registrationService = RegistrationServiceImpl.GetService();
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
