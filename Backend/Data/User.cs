namespace DesktopApp.Backend.Data
{
    public class User
    {


        private string email;

        private Role role;

        private string token;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetRole(Role role)
        {
            this.role = role;
        }

        public Role GetRole()
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