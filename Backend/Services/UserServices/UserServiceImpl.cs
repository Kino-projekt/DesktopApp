using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.ConnectionServices;

namespace DesktopApp.Backend.Services.UserServices
{
    public class UserServiceImpl : UserService
    {
        private User accountUser = null;

        public bool IsUserExist()
        {
            if (accountUser == null)
                return false;
            return true;
        }
    }
}