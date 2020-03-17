using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services;

namespace Tests.Imitations
{
    public class ConnectionServiceImitation : ConnectionService
    {
        // Class to imitation connection with server, only for tests, every method always return true

        public bool Singup(User user)
        {
            return true;
        }
    }
}