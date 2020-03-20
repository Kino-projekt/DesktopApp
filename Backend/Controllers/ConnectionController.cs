using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.ConnectionServices;

namespace DesktopApp.Backend.Controllers
{
    public class ConnectionController
    {
        private static ConnectionService connectionService;

        public static ConnectionService GetConnectionService()
        {
            if (connectionService == null)
            {
                connectionService = new ConnectionServiceImpl();
            }

            return connectionService;
        }
    }
}