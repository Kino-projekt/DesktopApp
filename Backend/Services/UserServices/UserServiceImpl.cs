using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.UserServices
{
    public class UserServiceImpl : UserService
    {
        private UserData userData;
        private bool isUserExist;

        public bool IsUserExist()
        {
            return isUserExist;
        }

        public void PutNewUser(UserData newUserData)
        {
            this.userData = newUserData;
            isUserExist = true;
        }

        public void RemoveUser()
        {
            userData = null;
            isUserExist = false;
        }
    }
}