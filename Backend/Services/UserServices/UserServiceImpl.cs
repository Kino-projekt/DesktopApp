using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.UserServices
{
    public class UserServiceImpl : UserService
    {
        private UserData userData;
        private bool userStatus;

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
            FormsController.GetFormService().GetMainForm().SetUserStatus(userStatus);
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