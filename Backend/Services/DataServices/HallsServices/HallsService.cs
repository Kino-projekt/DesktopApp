using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.HallsServices
{
    public interface HallsService
    {
        List<Hall> GetHallsList();
        void DownloadHallsList();
    }
}