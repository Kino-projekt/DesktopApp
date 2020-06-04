using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.HallsServices
{
    public class HallsAdminServiceImpl : HallsAdminService
    {
        private static HallsAdminService adminService;
        private List<Hall> halls;
        private HallAdminConnection connection;
        private HallsAdminServiceImpl()
        {
            connection = new HallAdminConnectionImpl();
            DownloadHallsList();
        }
        public static HallsAdminService GetService()
        {
            if (adminService == null)
                adminService = new HallsAdminServiceImpl();
            return adminService;
        }
        public List<Hall> GetHallsList()
        {
            if (halls == null)
                DownloadHallsList();
            return halls;
        }

        public void SendHall(Hall hall)
        {
            connection.SendHall(hall);
        }

        public void DeleteHall(Hall hall)
        {
            connection.DeleteHall(hall);
        }

        public void DownloadHallsList()
        {
            halls = connection.DownloadHalls();
        }
    }
}