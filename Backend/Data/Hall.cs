namespace DesktopApp.Backend.Data
{
    public class Hall
    {
        private int id;
        private string name;

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }
    }
}