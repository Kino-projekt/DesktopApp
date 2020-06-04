using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public interface SeanceAdminConnection
    {
        void SendSeance(Seance seance);
        List<Seance> DownloadSeances();
        void DeleteSeance(Seance seance);
    }
}