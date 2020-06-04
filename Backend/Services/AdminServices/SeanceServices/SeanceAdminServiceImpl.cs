using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.SeanceServices
{
    public class SeanceAdminServiceImpl : SeanceAdminService
    {
        private static SeanceAdminService adminService;
        private List<Seance> seances;
        private SeanceAdminConnection connectionController;

        private SeanceAdminServiceImpl()
        {
            connectionController = new SeanceAdminConnectionImpl();
            DownloadSeanceList();
        }

        public static SeanceAdminService GetService()
        {
            if (adminService == null)
                adminService = new SeanceAdminServiceImpl();
            return adminService;
        }

        public List<Seance> GetSeanceListForAdmin()
        {
            if (seances == null)
                DownloadSeanceList();
            return seances;
        }

        public void SendSeanceToServer(Seance seance)
        {
            connectionController.SendSeance(seance);
        }

        public void DeleteSeance(Seance seance)
        {
            connectionController.DeleteSeance(seance);
        }

        public void DownloadSeanceList()
        {
            seances = connectionController.DownloadSeances();
        }
    }
}