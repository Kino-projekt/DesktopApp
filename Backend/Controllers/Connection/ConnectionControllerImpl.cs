using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.SaveServices;
using DesktopApp.Backend.Services.UserServices;
using DesktopApp.Forms.LoadForm;
using DesktopApp.Properties;

namespace DesktopApp.Backend.Controllers.Connection
{
    public class ConnectionControllerImpl : ConnectionController
    {
        private HttpClient client;
        private string serverAdress = BasicConfiguration.GetServerAdress();

        public static ConnectionController GetController()
        {
            return new ConnectionControllerImpl();
        }

        private ConnectionControllerImpl()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(serverAdress)
            };
        }

        public bool Singup(AuthData user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signup", content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
            {
                return true;
            }
            DialogMessage.ShowInfo("Rejestracja nieudana!");
            return false;
        }

        public bool Singin(AuthData user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signin", content).Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                UserCreator.PutUserToSystem(response);
                SaveService.SaveUser(user);
                return true;
            }
            DialogMessage.ShowInfo("Logowanie nieudane!");
            return false;
        }

        public List<Article> GetArticlesFromServer()
        {
            HttpResponseMessage response = client.GetAsync("/api/articles").Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return ArticleListCreator.CreateArticles(response);
            }
            return null;
        }

        public List<Movie> GetMoviesFromServer()
        {
            List<Movie> movies;
            HttpResponseMessage response = client.GetAsync("/api/movies").Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                movies = MoviesListCreator.CreateMovies(response);
                return movies;
            }

            DialogMessage.ShowInfo("Błąd pobierania filmów!");
            return null;
        }
    }
}