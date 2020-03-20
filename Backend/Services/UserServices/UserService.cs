using DesktopApp.Backend.Services.ConnectionServices;

namespace DesktopApp.Backend.Services.UserServices
{
    public interface UserService
    {
        bool RegisterNewUser();
        bool LoginToSystem();

        bool SetUserEmail(string email);
        bool SetUserPassword(string password);

        void SetConnectionService(ConnectionService connectionService);

    }
}