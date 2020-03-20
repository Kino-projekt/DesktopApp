using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.UserServices;

namespace DesktopApp.Backend.Controllers
{
    public class UserController
    {
        private static UserService userService;

        public static UserService GetUserService()
        {
            if (userService == null)
            {
                userService = new UserServiceImpl();
            }

            return userService;
        }
    }
}