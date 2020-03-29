namespace DesktopApp.Backend.Data
{
    public class AuthData
    {
        private string email;
        private string password;

        public AuthData() { }

        public AuthData(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}