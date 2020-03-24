namespace DesktopApp.Backend.Data
{
    public class Article
    {
        private string title;
        private string description;

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
    }
}