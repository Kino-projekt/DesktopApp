using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.StandardConnections
{
    public interface ConnectionController
    {
        bool SingUp(AuthData user);
        bool SingIn(AuthData user);

        List<Article> GetArticlesFromServer();
        List<Movie> GetMoviesFromServer();
        List<Hall> GetHallsFromServer();
        List<Seance> GetSeancesFromServer();
    }
}