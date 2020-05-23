using System;

namespace DesktopApp.Backend.Data
{
    public class Article
    {
        private int id;
        private string title;
        private string description;
        private Status status;
        private string date;

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

        public void SetStatus(Status status)
        {
            this.status = status;
        }

        public Status GetStatus()
        {
            return status;
        }

        public void SetDate(string date)
        {
            this.date = date;
        }

        public string GetDate()
        {
            return date;
        }
    }
}