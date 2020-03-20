using DesktopApp.Backend.Services.AccessServices.LoginServices;

namespace DesktopApp.Backend.Controllers.AccessControllers
{
    public class LoginController
    {
        private static LoginService loginService;

        public static LoginService GetLoginService()
        {
            return loginService = new LoginServiceImpl(); ;
        }
    }
}