using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public interface MovieAdminConnection
    {
        void SendMovie(Movie movie);
        List<Movie> DownloadMovies();
        void DeleteMovie(Movie movie);
    }
}