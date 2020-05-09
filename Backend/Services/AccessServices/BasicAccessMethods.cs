using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AccessServices
{
    public class BasicAccessMethods
    {
        private ConnectionController connection;
        private AuthData user;
        private bool emailCurrect = false;
        private bool passwordCurrect = false;

        public BasicAccessMethods()
        {
            user = new AuthData();
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

        public bool CheckUserData()
        {
            if (emailCurrect == false)
                return false;
            if (passwordCurrect == false)
                return false;
            return true;
        }

        public bool IsEmailCurrect()
        {
            return emailCurrect;
        }

        public bool IsPasswordCurrect()
        {
            return passwordCurrect;
        }

        public AuthData GetAuthData()
        {
            return user;
        }

        public ConnectionController GetConnectionController()
        {
            return connection;
        }
    }
}