using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.StandardConnections.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.StandardConnections
{
    public class ConnectionControllerImpl : ConnectionController
    {
        public static ConnectionController GetController()
        {
            return new ConnectionControllerImpl();
        }

        public bool SingUp(AuthData user)
        {
           return MyAuthorization.SingUp(user);
        }

        public bool SingIn(AuthData user)
        {
            return MyAuthorization.SingIn(user);
        }

        public List<Article> GetArticlesFromServer()
        {
            return GetMethods.Articles();
        }

        public List<Movie> GetMoviesFromServer()
        {
            return GetMethods.Movies();
        }

        public List<Hall> GetHallsFromServer()
        {
            return GetMethods.Halls();
        }

        public List<Seance> GetSeancesFromServer()
        {
            return GetMethods.Seances();
        }
    }
}