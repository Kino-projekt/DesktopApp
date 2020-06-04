using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations
{
    public class MovieAdminConnectionImpl : MovieAdminConnection
    {
        public void SendMovie(Movie movie)
        {
            AdminPostMethods.Send(movie);
        }

        public List<Movie> DownloadMovies()
        {
            return AdminGetMethods.Movies();
        }

        public void DeleteMovie(Movie movie)
        {
            AdminDeleteMethods.Delete(movie);
        }
    }
}