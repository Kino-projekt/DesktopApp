namespace DesktopApp.Backend.Configuration
{
    public class BasicConfiguration
    {
        private static string SERVER_ADRESS = "https://afternoon-waters-37189.herokuapp.com";

        private static bool userRemember = false;
        public static string GetServerAdress()
        {
            return SERVER_ADRESS;
        }

        public static void SetUserRemember(bool remember)
        {
            userRemember = remember;
        }

        public static bool GetUserRemember()
        {
            return userRemember;
        }
    }
}