namespace DesktopApp.Backend.Configuration
{
    public class DataValidation
    {
        private static int MIN_PASSWORD_SIZE = 6;
        private static int MAX_PASSWORD_SIZE = 20;

        public static bool CheckPassword(string password)
        {
            // first version of validation 
            int size = password.Length;
            if (size <= MIN_PASSWORD_SIZE)
                return false;
            if (size >= MAX_PASSWORD_SIZE)
                return false;
            return true;
        }

        public static bool CheckEmail(string email)
        {
            if (email.Length == 0)
                return false;
            return true;
        }


    }
}