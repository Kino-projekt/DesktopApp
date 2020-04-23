namespace DesktopApp.Backend.Data
{
    public class Article
    {
        private int id;
        private string title;
        private string description;
        private string status;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }

        public string GetStatus()
        {
            return status;
        }
    }
}