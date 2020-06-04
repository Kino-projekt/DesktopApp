using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public interface UsersAdminConnection
    {
        List<User> DownloadUsers();
        void BanUser(User user);
        void ChangeUserRole(User user);
    }
}