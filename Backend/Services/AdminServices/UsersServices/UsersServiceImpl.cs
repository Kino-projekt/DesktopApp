using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.UsersServices
{
    public class UsersServiceImpl : UsersService
    {
        private static UsersService usersService;
        private List<User> users;
        private AdminConnectionController connectionController;

        private UsersServiceImpl()
        {
            connectionController = AdminConnectionControllerImpl.GetController();
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

        public void DownloadUserList()
        {
            users = connectionController.GetUsersListFromServer();
        }
    }
}