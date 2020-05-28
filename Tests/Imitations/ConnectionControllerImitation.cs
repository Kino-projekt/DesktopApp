using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Connection.StandardConnections;
using DesktopApp.Backend.Data;

namespace Tests.Imitations
{
    public class ConnectionControllerImitation : ConnectionController
    {

        public bool SingUp(AuthData user)
        {
            return true;
        }

        public bool SingIn(AuthData user)
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