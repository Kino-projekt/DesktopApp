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
            if (objects.Count == 0)
            {
                return null;
            }
            else
            {
                return DecodeList(objects);
            }
        }

        private static List<Movie> DecodeList(List<Object> objects)
        {
            List<Movie> movies = new List<Movie>();
            int size = objects.Count;

            for (int i = 0; i < size; i++)
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