namespace DesktopApp.Backend.Data
{
    public class Comment
    {
        private int id;
        private string content;
        private User author;
        private int movieId;

        public void SetID(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }

        public void SetAutor(User author)
        {
            this.author = author;
        }

        public void SetMovieId(int id)
        {
            movieId = id;
        }

        public int GetMovieId()
        {
            return movieId;
        }


    }
}