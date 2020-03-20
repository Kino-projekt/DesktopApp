using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.ConnectionServices;

namespace DesktopApp.Backend.Services.AccessServices.LoginServices
{
    public class LoginServiceImpl : LoginService
    {
        private ConnectionService connection;
        private User user;
        private bool emailCurrect = false;
        private bool passwordCurrect = false;

        public LoginServiceImpl()
        {
            connection = ConnectionController.GetConnectionService();
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

        public void SetConnectionService(ConnectionService connectionService)
        {
            connection = connectionService;
        }
    }
}