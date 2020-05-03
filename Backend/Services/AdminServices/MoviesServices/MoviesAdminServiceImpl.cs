using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.MoviesServices
{
    public class MoviesAdminServiceImpl : MoviesAdminService
    {
        private static MoviesAdminService adminService;
        private List<Movie> movies;
        private AdminConnectionController connectionController;

        private MoviesAdminServiceImpl()
        {
            connectionController = AdminConnectionControllerImpl.GetController();
            DownloadMoviesList();
        }

        public static MoviesAdminService GetService()
        {
            if (adminService == null)
                adminService = new MoviesAdminServiceImpl();
            return adminService;
        }

        public List<Movie> GetMoviesListForAdmin()
        {
            if(movies==null)
                DownloadMoviesList();
            return movies;
        }

        public void SendMovieToServer(Movie movie)
        {
            connectionController.SendMovie(movie);
        }

        public void DownloadMoviesList()
        {
            movies = connectionController.GetMoviesListFromServer();
        }
    }
}