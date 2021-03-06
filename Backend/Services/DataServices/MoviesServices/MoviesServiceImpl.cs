﻿using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Controllers.Connection.StandardConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.MoviesServices
{
    public class MoviesServiceImpl : MoviesService
    {
        private static MoviesService moviesService;
        private List<Movie> movies;
        private ConnectionController connection;

        private MoviesServiceImpl()
        {
            connection = ConnectionControllerImpl.GetController();
            DownloadMoviesList();
        }

        public static MoviesService GetService()
        {
            if(moviesService==null)
                moviesService = new MoviesServiceImpl();
            return moviesService;
        }

        public List<Movie> GetMoviesList()
        {
            if(movies==null)
                DownloadMoviesList();
            return movies;
        }

        public void DownloadMoviesList()
        {
            movies = connection.GetMoviesFromServer();
        }
    }
}