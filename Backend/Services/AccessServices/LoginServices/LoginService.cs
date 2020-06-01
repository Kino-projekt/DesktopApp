using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Connection.StandardConnections;

namespace DesktopApp.Backend.Services.AccessServices.LoginServices
{
    public interface LoginService
    {
        bool LoginNewUser();
        bool SetUserEmail(string email);
        bool SetUserPassword(string password);
        void SetConnectionController(ConnectionController connectionService);
    }
}