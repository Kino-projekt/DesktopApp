using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations
{
    public class UsersAdminConnectionImpl : UsersAdminConnection
    {
        public List<User> DownloadUsers()
        {
            return AdminGetMethods.Users();
        }

        public void BanUser(User user)
        {
            AdminSpecificMethods.BanUser(user);
        }

        public void ChangeUserRole(User user)
        {
            AdminSpecificMethods.ChangeUserRole(user);
        }
    }
}