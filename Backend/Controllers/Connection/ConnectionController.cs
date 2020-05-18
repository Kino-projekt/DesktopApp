using System.Collections.Generic;
using System.Threading.Tasks;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection
{
    public interface ConnectionController
    {
        bool Singup(AuthData user);
        bool Singin(AuthData user);

        List<Article> GetArticlesFromServer();
        List<Movie> GetMoviesFromServer();


    }
}