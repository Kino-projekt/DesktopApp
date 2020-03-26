using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.UserServices
{
    public interface UserService
    {
        bool GetUserStatus();
        void PutNewUser(UserData userData);
        void RemoveUser();
    }
}