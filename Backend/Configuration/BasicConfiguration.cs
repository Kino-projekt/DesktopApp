namespace DesktopApp.Backend.Configuration
{
    public class BasicConfiguration
    {
        private static string SERVER_ADRESS = "https://afternoon-waters-37189.herokuapp.com";
        public static string GetServerAdress()
        {
            return SERVER_ADRESS;
        }
    }
}