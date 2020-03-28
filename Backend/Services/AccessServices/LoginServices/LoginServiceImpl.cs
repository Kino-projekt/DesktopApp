using System.Security.Policy;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;


namespace DesktopApp.Backend.Services.AccessServices.LoginServices
{
    public class LoginServiceImpl : LoginService
    {
        private ConnectionController connection;
        private User user;
        private bool emailCurrect = false;
        private bool passwordCurrect = false;

        public static LoginService GetService()
        {
            return new LoginServiceImpl();
        }

        private LoginServiceImpl()
        {
            connection = ConnectionControllerImpl.GetController();
            user = new User();
        }

        public bool LoginNewUser()
        {
            if (emailCurrect)
            {
                if (passwordCurrect)
                    return connection.Singin(user);
            }

            return false;
        }

        public bool SetUserEmail(string email)
        {
            emailCurrect = DataValidation.CheckEmail(email);
            if (emailCurrect)
            {
                user.SetEmail(email);
                return true;
            }
            return false;
        }

        public bool SetUserPassword(string password)
        {
            passwordCurrect = DataValidation.CheckPassword(password);
            if (passwordCurrect)
            {
                user.SetPassword(password);
                return true;
            }
            return false;
        }

        public void SetConnectionController(ConnectionController connectionService)
        {
            connection = connectionService;
        }
    }
}