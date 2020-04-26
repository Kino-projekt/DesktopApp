using System;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Services.AccessServices.RegistrationServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.AccessForms.RegistrationForm
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
                passwordSizeLabel.Visible = false;
                passwordCharLabel.Visible = false;
                return true;
            }
            else
            {
                wrongPasswordLabel.Visible = true;
                passwordSizeLabel.Visible = true;
                passwordCharLabel.Visible = true;
            }
            return false;
        }
    }
}
