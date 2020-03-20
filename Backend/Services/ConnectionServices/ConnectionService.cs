using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.ConnectionServices
{
    public interface ConnectionService
    {
        bool Singup(User user);
        bool Singin(User user);
    }
}