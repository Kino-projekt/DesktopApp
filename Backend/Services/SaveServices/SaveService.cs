using DesktopApp.Backend.Data;
using DesktopApp.Properties;

namespace DesktopApp.Backend.Services.SaveServices
{
    public class SaveService
    {
        private static bool rememberUser = false;
        public static void SaveUser(AuthData user)
        {
            if (rememberUser)
            {
                Settings.Default.Email = Cipher.Encrypt(user.GetEmail());
                Settings.Default.Password = Cipher.Encrypt(user.GetPassword());
                Settings.Default.Save();
            }
        }

        public static void RemoveUser()
        {
            Settings.Default.Email = "";
            Settings.Default.Password = "";
            Settings.Default.Save();
        }

        public static AuthData GetUser()
        {
            string email = Cipher.Decrypty(Settings.Default.Email);
            string password = Cipher.Decrypty(Settings.Default.Password);
            return new AuthData(email, password);
        }

        public static void SetRememberUser(bool remember)
        {
            rememberUser = remember;
        }
    }
}