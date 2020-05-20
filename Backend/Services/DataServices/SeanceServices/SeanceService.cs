using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.SeanceServices
{
    public interface SeanceService
    {
        List<Seance> GetSeanceList();

        void DownloadSeanceList();
    }
}