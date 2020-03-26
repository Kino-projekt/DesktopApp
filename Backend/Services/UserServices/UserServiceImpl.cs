using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using FormsController = DesktopApp.Backend.Controllers.Forms.FormsController;

namespace DesktopApp.Backend.Services.UserServices
{
    public class UserServiceImpl : UserService
    {
        private static UserService userService = new UserServiceImpl();
        private UserData userData;
        private bool userStatus;

        public static UserService GetInstance()
        {
            return userService;
        }

        private UserServiceImpl() { }

        public bool GetUserStatus()
        {
            return userStatus;
        }

        public void PutNewUser(UserData newUserData)
        {
            this.userData = newUserData;
            userStatus = true;
            SendUserStatusToMainForm();
            NewArticleToTest();
        }

        public void RemoveUser()
        {
            userData = null;
            userStatus = false;
            SendUserStatusToMainForm();
        }

        private void SendUserStatusToMainForm()
        {
            FormsController formsController = FormsControllerImpl.GetInstance();
            MainForm.MainForm mainForm = formsController.GetMainForm();
            mainForm.SetUserStatus(userStatus);
            //FormsController.GetFormService().GetMainForm().SetUserStatus(userStatus);
        }

        private void NewArticleToTest()
        {
            Article article = new Article();
            article.SetTitle("Jaskot");
            article.SetDescription("Życie jest za krótkie by programować w C#");


            ConnectionController.GetConnectionService().SendArticle(userData, article);
        }
    }
}