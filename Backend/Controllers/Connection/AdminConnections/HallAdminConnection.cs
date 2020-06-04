using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public interface HallAdminConnection
    {
        void SendHall(Hall hall);
        List<Hall> DownloadHalls();
        void DeleteHall(Hall hall);
    }
}