using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations
{
    public class SeanceAdminConnectionImpl : SeanceAdminConnection
    {
        public void SendSeance(Seance seance)
        {
            AdminPostMethods.Send(seance);
        }

        public List<Seance> DownloadSeances()
        {
            return AdminGetMethods.Seances();
        }

        public void DeleteSeance(Seance seance)
        {
            AdminDeleteMethods.Delete(seance);
        }
    }
}