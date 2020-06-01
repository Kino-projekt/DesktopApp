using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.SaveServices;
using FormsController = DesktopApp.Backend.Controllers.Forms.FormsController;

namespace DesktopApp.Backend.Services.UserServices
{
    public class MainUserServiceImpl : MainUserService
    {
        private static MainUserService _mainUserService;
        private User user;

        public static MainUserService GetInstance()
        {
            if(_mainUserService==null)
                _mainUserService = new MainUserServiceImpl();
            return _mainUserService;
        }

        private MainUserServiceImpl() { }

        public Role GetUserRole()
        {
            if (user == null)
                return Role.DEFAULT;

            return user.GetRole();
        }

        public void PutNewUser(User user)
        {
            this.user = user;
            SendUserStatusToMainForm();
        }

        public void RemoveUser()
        {
            user = null;
            SaveService.RemoveUser();
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
            return user.GetEmail();
        }

        public string GetUserToken()
        {
            return user.GetToken();
        }

        public int GetUserId()
        {
            return user.GetId();
        }
    }
}