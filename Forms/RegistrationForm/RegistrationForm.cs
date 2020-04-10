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
        private RegistrationService registrationService;
        public RegistrationForm()
        {
            InitializeComponent();
            DesingerService desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            registrationService = RegistrationServiceImpl.GetService();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Close();
            FormsController formsController = FormsControllerImpl.GetInstance();
            formsController.OpenLoginForm();
        }

        private void regitstrationButton_Click(object sender, EventArgs e)
        {

            if (CheckEmail() && CheckPassword())
            {
                Cursor.Current = Cursors.WaitCursor;
                if (registrationService.RegisterNewUser())
                    Close(); //registration form
                Cursor.Current = Cursors.Default;
            }
        }

        private bool CheckEmail()
        {
            string email = emailField.Text;
            if (registrationService.SetUserEmail(email))
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
            if (registrationService.SetUserPassword(password))
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
