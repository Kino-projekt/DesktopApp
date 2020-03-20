using DesktopApp.Forms.LoginForm;
using DesktopApp.Forms.RegistrationForm;

namespace DesktopApp.Backend.Services.FormServices
{
    public class FormServiceImpl : FormService
    {


        public void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public void OpenRegitrationForm()
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

    }
}