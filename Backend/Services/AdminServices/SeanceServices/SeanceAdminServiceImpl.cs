using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.SeanceServices
{
    public class SeanceAdminServiceImpl : SeanceAdminService
    {
        private static SeanceAdminService adminService;
        private List<Seance> seances;
        private AdminConnectionController connectionController;

        private SeanceAdminServiceImpl()
        {
            connectionController = AdminConnectionControllerImpl.GetController();
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
            
        }
    }
}