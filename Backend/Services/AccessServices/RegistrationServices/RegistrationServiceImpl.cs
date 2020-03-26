using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AccessServices.RegistrationServices
{
    public class RegistrationServiceImpl : RegistrationService
    {
        private ConnectionController connection;
        private User user;

        public static RegistrationService GetService()
        {
            return new RegistrationServiceImpl();
        }

        private RegistrationServiceImpl()
        {
            connection = ConnectionControllerImpl.GetController();
            user = new User();
        }

        public bool RegisterNewUser()
        {
            return connection.Singup(user);
        }

        public bool SetUserEmail(string email)
        {
            if (DataValidation.CheckEmail(email))
            {
                user.SetEmail(email);
                return true;
            }
            return false;
        }

        public bool SetUserPassword(string password)
        {
            if (DataValidation.CheckPassword(password))
            {
                user.SetPassword(password);
                return true;
            }
            return false;
        }

        public void SetConnectionService(ConnectionController connection)
        {
            this.connection = connection;
        }
    }
}