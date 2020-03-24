namespace DesktopApp.Backend.Data
{
    public class UserData
    {
        private string email;

        private string token;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetToken(string token)
        {
            this.token = token;
        }

        public string GetToken()
        {
            return token;
        }
    }
}