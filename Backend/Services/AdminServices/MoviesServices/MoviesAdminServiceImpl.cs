using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.MoviesServices
{
    public class MoviesAdminServiceImpl : MoviesAdminService
    {
        private static MoviesAdminService adminService;
        private List<Movie> movies;
        private MovieAdminConnection connection;

        private MoviesAdminServiceImpl()
        {
            connection = new MovieAdminConnectionImpl();
            DownloadMoviesList();
        }

        public static MoviesAdminService GetService()
        {
            if (adminService == null)
                adminService = new MoviesAdminServiceImpl();
            return adminService;
        }

        public List<Movie> GetMoviesList()
        {
            if(movies==null)
                DownloadMoviesList();
            return movies;
        }

        public void SendMovie(Movie movie)
        {
            connection.SendMovie(movie);
        }

        public void DeleteMovie(Movie movie)
        {
            connection.DeleteMovie(movie);
        }

        public void DownloadMoviesList()
        {
            movies = connection.DownloadMovies();
        }
    }
}