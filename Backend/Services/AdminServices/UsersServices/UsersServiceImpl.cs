using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.UsersServices
{
    public class UsersServiceImpl : UsersService
    {
        private List<User> users;
        private AdminConnectionController connectionController;

        private UsersServiceImpl()
        {
            connectionController = AdminConnectionControllerImpl.GetController();
        }

        public static UsersService GetService()
        {
            return new UsersServiceImpl();
        }

        public List<User> GetUsersList()
        {
            users = connectionController.GetUsersListFromServer();
            return users;
        }
    }
}