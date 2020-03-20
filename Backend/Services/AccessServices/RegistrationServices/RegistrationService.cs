using DesktopApp.Backend.Services.ConnectionServices;

namespace DesktopApp.Backend.Services.AccessServices.RegistrationServices
{
    public interface RegistrationService
    {

        bool RegisterNewUser();
        bool SetUserEmail(string email);
        bool SetUserPassword(string password);

        void SetConnectionService(ConnectionService connectionService);

    }
}