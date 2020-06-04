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
        private UsersAdminConnection connectionController;

        private UsersServiceImpl()
        {
            connectionController = new UsersAdminConnectionImpl();
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
            connectionController.BanUser(user);
        }

        public void ChangeRole(User user)
        {
            connectionController.ChangeUserRole(user);
        }

        public void DownloadUserList()
        {
            users = connectionController.DownloadUsers();
        }
    }
}