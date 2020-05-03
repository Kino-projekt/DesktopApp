using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.MoviesServices
{
    public interface MoviesAdminService
    {
        List<Movie> GetMoviesListForAdmin();

        void SendMovieToServer(Movie movie);

        void DownloadMoviesList();
    }
}