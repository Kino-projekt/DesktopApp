using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations
{
    public class HallAdminConnectionImpl: HallAdminConnection
    {
        public void SendHall(Hall hall)
        {
            AdminPostMethods.Send(hall);
        }

        public List<Hall> DownloadHalls()
        {
            return AdminGetMethods.Halls();
        }

        public void DeleteHall(Hall hall)
        {
            AdminDeleteMethods.Delete(hall);
        }
    }
}