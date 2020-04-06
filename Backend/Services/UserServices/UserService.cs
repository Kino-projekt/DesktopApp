using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.UserServices
{
    public interface UserService
    {
        Role GetUserRole();
        void PutNewUser(User userData);
        void RemoveUser();
        string GetUserEmail();
    }
}