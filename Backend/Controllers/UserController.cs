using DesktopApp.Backend.Services;

namespace DesktopApp.Backend.Controllers
{
    public class UserController
    {
        private static UserService userService;

        public static UserService GetFormService()
        {
            if (userService == null)
            {
                userService = new UserServiceImpl();
            }

            return userService;
        }
    }
}