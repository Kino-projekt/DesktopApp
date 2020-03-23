using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.ConnectionServices;

namespace DesktopApp.Backend.Services.UserServices
{
    public interface UserService
    {
        bool IsUserExist();
        void PutNewUser(UserData userData);

        void RemoveUser();
    }
}