using DesktopApp.Backend.Controllers.Connection;

namespace DesktopApp.Backend.Services.AccessServices.LoginServices
{
    public interface LoginService
    {
        bool LoginNewUser();
        bool SetUserEmail(string email);
        bool SetUserPassword(string password);

        void SetConnectionService(ConnectionController connectionService);
    }
}