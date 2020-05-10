﻿using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class ContentCreator
    {

        public static FormUrlEncodedContent CreateContent(AuthData user)
        {
            return new FormUrlEncodedContent(CreatePairs(user));
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

        public static FormUrlEncodedContent CreateContent(Hall hall)
        {
            return new FormUrlEncodedContent(CreatePairs(hall));
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

        private static List<KeyValuePair<string, string>> CreatePairs(Article article)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("title", article.GetTitle()),
                new KeyValuePair<string, string>("description", article.GetDescription())
            };
            return pairs;
        }

        private static List<KeyValuePair<string, string>> CreatePairs(Status status)
        {
            List<KeyValuePair<string, string>> pairs;
            if (status == Status.Active)
            {
                return pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("status", "INACTIVE"),
                };
            }
            else
            {
                return pairs = new List<KeyValuePair<string, string>>
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
                new KeyValuePair<string, string>("name", hall.GetName())
            };
            return pairs;
        }
    }
}