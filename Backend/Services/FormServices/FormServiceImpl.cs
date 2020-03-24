using DesktopApp.Forms.LoginForm;
using DesktopApp.Forms.RegistrationForm;

namespace DesktopApp.Backend.Services.FormServices
{
    public class FormServiceImpl : FormService
    {
        private MainForm.MainForm mainForm;

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

        public MainForm.MainForm GetMainForm()
        {
            if (mainForm == null)
            {
                mainForm = new MainForm.MainForm();
            }
            return mainForm;
        }
    }
}