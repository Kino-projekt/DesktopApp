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
        private string singUpAdress = "/api/auth/signup";
        private string singInAdress = "/api/auth/signin";
        private string moviesAdress = "/api/movies";
        private string articlesAdress = "/api/articles";

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
            HttpResponseMessage response = client.PostAsync(singUpAdress, content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
                return true;

            DialogMessage.ShowInfo("Rejestracja nieudana!");
            return false;
        }

        public bool Singin(AuthData user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = client.PostAsync(singInAdress, content).Result;
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
            HttpResponseMessage response = client.GetAsync(articlesAdress).Result;
            if (response.StatusCode == HttpStatusCode.OK)
                return ArticleListCreator.CreateArticles(response);

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return null;
        }

        public List<Movie> GetMoviesFromServer()
        {
            HttpResponseMessage response = client.GetAsync(moviesAdress).Result;
            if (response.StatusCode == HttpStatusCode.OK)
                return MoviesListCreator.CreateMovies(response);

            DialogMessage.ShowInfo("Błąd pobierania filmów!");
            return null;
        }
    }
}