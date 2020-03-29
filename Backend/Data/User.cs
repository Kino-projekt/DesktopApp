namespace DesktopApp.Backend.Data
{
    public class User
    {


        private string email;

        private string role;

        private string token;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetRole(string role)
        {
            this.role = role;
        }

        public string GetRole()
        {
            return role;
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