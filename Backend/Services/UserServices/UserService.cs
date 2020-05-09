using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.UserServices
{
    public interface UserService
    {
        void PutNewUser(User userData);
        Role GetUserRole();
        string GetUserEmail();
        string GetUserToken();
        void RemoveUser();
    }
}