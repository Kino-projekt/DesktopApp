using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.HallsServices
{
    public interface HallsAdminService
    {
        List<Hall> GetHallsList();
        void SendHall(Hall hall);
        void DeleteHall(Hall hall);
        void DownloadHallsList();
    }
}