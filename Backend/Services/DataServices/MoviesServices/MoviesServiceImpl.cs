using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.MoviesServices
{
    public class MoviesServiceImpl : MoviesService
    {
        private List<Movie> articles;
        private ConnectionController connectionController;

        private MoviesServiceImpl()
        {
            connectionController = ConnectionControllerImpl.GetController();
        }

        public static MoviesService GetService()
        {
            return new MoviesServiceImpl();
        }

        public List<Movie> GetMoviesList()
        {
            throw new System.NotImplementedException();
        }

    }
}