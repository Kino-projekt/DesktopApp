using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

                string body = movieObject.comments.ToString();
                List<Object> commList = JsonConvert.DeserializeObject<List<Object>>(body);
                movie.SetCommentsList(CreateCommentsList(commList));

                movies.Add(movie);
            }
            return movies;
        }

        private static List<Comment> CreateCommentsList(List<object> objects)
        {
            List<Comment> comments = new List<Comment>();
            for (int i = 0; i < objects.Count; i++)
            {
                Comment comment = new Comment();
                dynamic commentObject = objects[i];
                comment.SetID((int)commentObject.id);
                comment.SetContent((string)commentObject.content);

                comments.Add(comment);
            }
            return comments;
        }
    }
}