using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using FormsController = DesktopApp.Backend.Controllers.Forms.FormsController;

namespace DesktopApp.Backend.Services.UserServices
{
    public class UserServiceImpl : UserService
    {
        private static UserService userService = new UserServiceImpl();
        private User userData;

        public static UserService GetInstance()
        {
            return userService;
        }

        private UserServiceImpl() { }

        public Role GetUserRole()
        {
            if (userData == null)
            {
                return Role.DEFAULT;
            }
            return userData.GetRole();
        }

        public void PutNewUser(User newUserData)
        {
            this.userData = newUserData;
            SendUserStatusToMainForm();
        }

        public void RemoveUser()
        {
            userData = null;
            SendUserStatusToMainForm();
        }

        private void SendUserStatusToMainForm()
        {
            FormsController formsController = FormsControllerImpl.GetInstance();
            MainForm.MainForm mainForm = formsController.GetMainForm();
            mainForm.SetUserRole(GetUserRole());
        }

        public string GetUserEmail()
        {
            return userData.GetEmail();
        }
    }
}