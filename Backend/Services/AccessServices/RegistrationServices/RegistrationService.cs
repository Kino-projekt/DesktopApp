using DesktopApp.Backend.Controllers.Connection;

namespace DesktopApp.Backend.Services.AccessServices.RegistrationServices
{
    public interface RegistrationService
    {

        bool RegisterNewUser();
        bool SetUserEmail(string email);
        bool SetUserPassword(string password);

        void SetConnectionService(ConnectionController connection);

    }
}