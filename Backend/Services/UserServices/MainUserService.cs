using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.UserServices
{
    public interface MainUserService
    {
        void PutNewUser(User userData);
        Role GetUserRole();
        string GetUserEmail();
        string GetUserToken();
        int GetUserId();
        void RemoveUser();
    }
}