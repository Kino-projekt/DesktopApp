using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class MoviesListCreator
    {
        public static List<Movie> CreateMovies(HttpResponseMessage response)
        {
            string body = response.Content.ReadAsStringAsync().Result;
            List<Object> objects = JsonConvert.DeserializeObject<List<Object>>(body);
            return DecodeList(objects);
        }

        private static List<Movie> DecodeList(List<Object> objects)
        {
            List<Movie> movies = new List<Movie>();

            for (int i = 0; i < objects.Count; i++)
            {
                Movie movie = new Movie();
                dynamic movieObject = objects[i];

                movie.SetId((int)movieObject.id);
                movie.SetTitle((string)movieObject.title);
                movie.SetDescription((string)movieObject.description);
                movie.SetDirector((string)movieObject.director);

                movies.Add(movie);
            }
            return movies;
        }
    }
}