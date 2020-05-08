using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace Tests.Imitations
{
    public class ConnectionControllerImitation : ConnectionController
    {

        public bool Singup(AuthData user)
        {
            return true;
        }

        public bool Singin(AuthData user)
        {
            return true;
        }

        public List<Article> GetArticlesFromServer()
        {
            return new List<Article>();
        }

        public List<Movie> GetMoviesFromServer()
        {
            return new List<Movie>();
        }

        public void SendArticle(User userData, Article article)
        {
        }
    }
}