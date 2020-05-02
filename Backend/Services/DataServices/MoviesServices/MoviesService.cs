using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.MoviesServices
{
    public interface MoviesService
    {
        List<Movie> GetMoviesList();

        void DownloadMoviesList();
    }
}