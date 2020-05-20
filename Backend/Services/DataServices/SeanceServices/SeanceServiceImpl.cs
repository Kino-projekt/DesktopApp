using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.SeanceServices
{
    public class SeanceServiceImpl : SeanceService
    {
        private static SeanceService seanceService;
        private List<Seance> seances;
        private ConnectionController connectionController;

        private SeanceServiceImpl()
        {
            connectionController = ConnectionControllerImpl.GetController();
            DownloadSeanceList();
        }

        public static SeanceService GetService()
        {
            if (seanceService == null)
                seanceService = new SeanceServiceImpl();
            return seanceService;
        }

        public List<Seance> GetSeanceList()
        {
            if (seances == null)
                DownloadSeanceList();
            return seances;
        }

        public void DownloadSeanceList()
        {
            seances = connectionController.GetSeansecFromServer();
        }
    }
}