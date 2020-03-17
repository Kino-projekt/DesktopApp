using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services
{
    public class UserServiceImpl : UserService
    {
        private User user;
        private ConnectionService connection;

        public UserServiceImpl()
        {
            connection = ConnectionController.GetConnectionService();
        }

        public bool RegisterNewUser(string email, string password)
        {
            user = new User(email, password);
            return connection.Singup(user);
        }

        public bool LoginToSystem(string email, string password)
        {
            return false;
        }

        public void SetConnectionService(ConnectionService connectionService)
        {
            this.connection = connectionService;
        }
    }
}