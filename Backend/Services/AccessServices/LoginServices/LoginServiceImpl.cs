using DesktopApp.Backend.Controllers.Connection.StandardConnections;

namespace DesktopApp.Backend.Services.AccessServices.LoginServices
{
    public class LoginServiceImpl : BasicAccessMethods, LoginService
    {

        public static LoginService GetService()
        {
            return new LoginServiceImpl();
        }

        private LoginServiceImpl()
        {
            SetConnectionController(ConnectionControllerImpl.GetController());
        }

        public bool LoginNewUser()
        {
            if (CheckUserData())
                return GetConnectionController().SingIn(GetAuthData());

            return false;
        }
    }
}