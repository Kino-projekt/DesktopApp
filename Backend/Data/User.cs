namespace DesktopApp.Backend.Data
{
    public class User
    {
        private int id;

        private string email;

        private Role role;

        private string token;

        public void SetId(int i)
        {
            id = i;
        }

        public int GetId()
        {
            return id;
        }

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