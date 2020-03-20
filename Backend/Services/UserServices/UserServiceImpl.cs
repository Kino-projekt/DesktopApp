using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.ConnectionServices;

namespace DesktopApp.Backend.Services.UserServices
{
    public class UserServiceImpl : UserService
    {
        private User accountUser;
        private User newUser;
        private ConnectionService connection;

        public UserServiceImpl()
        {
            connection = ConnectionController.GetConnectionService();
            newUser = new User();
        }

        public bool RegisterNewUser()
        {
            return connection.Singup(newUser);
        }

        public bool LoginToSystem()
        {
            return false;
        }

        public bool SetUserEmail(string email)
        {
            newUser.SetEmail(email);
            return true;
        }

        public bool SetUserPassword(string password)
        {
            newUser.SetPassword(password);
            return true;
        }

        public void SetConnectionService(ConnectionService connectionService)
        {
            this.connection = connectionService;
        }
    }
}