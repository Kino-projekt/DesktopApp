using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class ContentCreator
    {

        public static FormUrlEncodedContent CreateContent(AuthData user)
        {
            return new FormUrlEncodedContent(CreatePairs(user));
        }

        public static FormUrlEncodedContent CreateContent(Role role)
        {
            return new FormUrlEncodedContent(CreatePairs(role));
        }

        public static FormUrlEncodedContent CreateContent(Article article)
        {
            return new FormUrlEncodedContent(CreatePairs(article));
        }

        public static FormUrlEncodedContent CreateContent(Status status)
        {
            return new FormUrlEncodedContent(CreatePairs(status));
        }

        public static FormUrlEncodedContent CreateContent(Movie movie)
        {
            return new FormUrlEncodedContent(CreatePairs(movie));
        }

        public static FormUrlEncodedContent CreateContent(Comment comment)
        {
            return new FormUrlEncodedContent(CreatePairs(comment));
        }

        public static StringContent CreateContent(Hall hall)
        {
            string myContent =  JsonConvert.SerializeObject(new
            {
                name = hall.GetName(),
                countOfSeats = hall.GetSeats(),
            });
            var content = new StringContent(myContent, Encoding.UTF8, "application/json");

            return content;
        }

        public static FormUrlEncodedContent CreateContent(Seance seance)
        {
            return new FormUrlEncodedContent(CreatePairs(seance));
        }

        private static List<KeyValuePair<string, string>> CreatePairs(AuthData user)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("email", user.GetEmail()),
                new KeyValuePair<string, string>("password", user.GetPassword())
            };
            return pairs;
        }

        private static List<KeyValuePair<string, string>> CreatePairs(Role role)
        {
            List<KeyValuePair<string, string>> pairs;
            if (role == Role.ADMIN)
            {
                return pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("role", "CUSTOMER"),
                };
            }
            else
            {
                return pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("role", "ADMIN"),
                };
            }

        }

        private static List<KeyValuePair<string, string>> CreatePairs(Article article)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("title", article.GetTitle()),
                new KeyValuePair<string, string>("description", article.GetDescription())
            };
            return pairs;
        }

        private static List<KeyValuePair<string, string>> CreatePairs(Comment comment)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("content", comment.GetContent()),
                new KeyValuePair<string, string>("movieId", comment.GetMovieId().ToString())
            };
            return pairs;
        }


        private static List<KeyValuePair<string, string>> CreatePairs(Status status)
        {
            if (status == Status.Active)
            {
                return new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("status", "INACTIVE"),
                };
            }
            else
            {
                return new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("status", "ACTIVE"),
                };
            }
        }

        private static List<KeyValuePair<string, string>> CreatePairs(Movie movie)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("title", movie.GetTitle()),
                new KeyValuePair<string, string>("description", movie.GetDescription()),
                new KeyValuePair<string, string>("director", movie.GetDirector()),
            };
            return pairs;
        }

        private static List<KeyValuePair<string, string>> CreatePairs(Hall hall)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("name", hall.GetName()),
                new KeyValuePair<string, string>("countOfSeats", hall.GetSeats().ToString())
            };
            return pairs;
        }
        private static List<KeyValuePair<string, int>> CreatePairsForSeats(Hall hall)
        {
            var pairs = new List<KeyValuePair<string, int>>
            {
                new KeyValuePair<string, int>("countOfSeats", hall.GetSeats())
            };
            return pairs;
        }

        private static List<KeyValuePair<string, string>> CreatePairs(Seance seance)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("movieId", seance.GetMovie().GetId().ToString()),
                new KeyValuePair<string, string>("hallId", seance.GetHall().GetId().ToString()),
                new KeyValuePair<string, string>("date", seance.GetDate())
            };
            return pairs;
        }
    }
}