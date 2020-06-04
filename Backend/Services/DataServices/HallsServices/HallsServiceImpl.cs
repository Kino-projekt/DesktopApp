using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Connection.StandardConnections;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.DataServices.MoviesServices;

namespace DesktopApp.Backend.Services.DataServices.HallsServices
{
    public class HallsServiceImpl : HallsService
    {
        private static HallsService hallsService;
        private List<Hall> halls;
        private ConnectionController connection;

        private HallsServiceImpl()
        {
            connection = ConnectionControllerImpl.GetController();
            DownloadHallsList();
        }

        public static HallsService GetService()
        {
            if (hallsService == null)
                hallsService = new HallsServiceImpl();
            return hallsService;
        }

        public List<Hall> GetHallsList()
        {
            if (halls == null)
                DownloadHallsList();
            return halls;
        }

        public void DownloadHallsList()
        {
            halls=connection.GetHallsFromServer();
        }
    }
}