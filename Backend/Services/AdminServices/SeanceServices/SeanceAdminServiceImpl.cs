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
        private SeanceAdminConnection connection;

        private SeanceAdminServiceImpl()
        {
            connection = new SeanceAdminConnectionImpl();
            DownloadSeanceList();
        }

        public static SeanceAdminService GetService()
        {
            if (adminService == null)
                adminService = new SeanceAdminServiceImpl();
            return adminService;
        }

        public List<Seance> GetSeanceList()
        {
            if (seances == null)
                DownloadSeanceList();
            return seances;
        }

        public void SendSeance(Seance seance)
        {
            connection.SendSeance(seance);
        }

        public void DeleteSeance(Seance seance)
        {
            connection.DeleteSeance(seance);
        }

        public void DownloadSeanceList()
        {
            seances = connection.DownloadSeances();
        }
    }
}