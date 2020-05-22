using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.SeanceServices
{
    public interface SeanceAdminService
    {
        List<Seance> GetSeanceListForAdmin();

        void SendSeanceToServer(Seance seance);

        void DeleteSeance(Seance seance);

        void DownloadSeanceList();
    }
}