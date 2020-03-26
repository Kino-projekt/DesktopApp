namespace DesktopApp.Backend.Controllers.Forms
{
    public interface FormsController
    {
        void OpenLoginForm();
        void OpenRegitrationForm();
        MainForm.MainForm GetMainForm();
    }
}