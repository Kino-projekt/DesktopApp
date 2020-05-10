using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.HallsServices
{
    public class HallsAdminServiceImpl : HallsAdminService
    {
        private static HallsAdminService adminService;
        private List<Hall> halls;
        private AdminConnectionController connectionController;
        private HallsAdminServiceImpl()
        {
            connectionController = AdminConnectionControllerImpl.GetController();
            DownloadHallsList();
        }
        public static HallsAdminService GetService()
        {
            if (adminService == null)
                adminService = new HallsAdminServiceImpl();
            return adminService;
        }
        public List<Hall> GetHallsListForAdmin()
        {
            if (halls == null)
                DownloadHallsList();
            return halls;
        }

        public void SendHallToServer(Hall hall)
        {
            connectionController.SendHall(hall);
        }

        public void DeleteHall(Hall hall)
        {
            connectionController.DeleteHall(hall);
        }

        public void DownloadHallsList()
        {
            halls = connectionController.GetHallsListFromServer();
        }
    }
}