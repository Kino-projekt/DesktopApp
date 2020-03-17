namespace DesktopApp.Backend.Services
{
    public interface UserService
    {
        bool RegisterNewUser(string email, string password);
        bool LoginToSystem(string email, string password);

        void SetConnectionService(ConnectionService connectionService);

    }
}