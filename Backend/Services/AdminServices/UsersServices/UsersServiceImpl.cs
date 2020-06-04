using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.UsersServices
{
    public class UsersServiceImpl : UsersService
    {
        private static UsersService usersService;
        private List<User> users;
        private UsersAdminConnection connection;

        private UsersServiceImpl()
        {
            connection = new UsersAdminConnectionImpl();
            DownloadUserList();
        }

        public static UsersService GetService()
        {
            if(usersService==null)
                usersService = new UsersServiceImpl();
            return usersService;
        }

        public List<User> GetUsersList()
        {
            if(users==null)
                DownloadUserList();
            return users;
        }

        public void BanUser(User user)
        {
            connection.BanUser(user);
        }

        public void ChangeRole(User user)
        {
            connection.ChangeUserRole(user);
        }

        public void DownloadUserList()
        {
            users = connection.DownloadUsers();
        }
    }
}