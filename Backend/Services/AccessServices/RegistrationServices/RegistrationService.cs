using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Connection.StandardConnections;

namespace DesktopApp.Backend.Services.AccessServices.RegistrationServices
{
    public interface RegistrationService
    {

        bool RegisterNewUser();
        bool SetUserEmail(string email);
        bool SetUserPassword(string password);

        void SetConnectionController(ConnectionController connection);

    }
}