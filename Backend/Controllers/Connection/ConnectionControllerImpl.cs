using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.SaveServices;
using DesktopApp.Forms.Notification;

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
        private string seancesAdress = "/api/seances";
        private string hallsAdress = "/api/halls";

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
            {
                NotifitactionForm.ShowMessage("Konto zarejestrowane!");
                return true;
            }

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
            return new List<Article>();
        }

        public List<Movie> GetMoviesFromServer()
        {
            HttpResponseMessage response = client.GetAsync(moviesAdress).Result;
            if (response.StatusCode == HttpStatusCode.OK)
                return MoviesListCreator.CreateMovies(response);

            DialogMessage.ShowInfo("Błąd pobierania filmów!");
            return new List<Movie>();
        }

        public List<Hall> GetHallsFromServer()
        {
            HttpResponseMessage response = client.GetAsync(hallsAdress).Result;
            if (response.StatusCode == HttpStatusCode.OK)
                return HallsListCreator.CreateHalls(response);

            DialogMessage.ShowInfo("Błąd pobierania sali!");
            return new List<Hall>();
        }

        public List<Seance> GetSeansecFromServer()
        {
            HttpResponseMessage response = client.GetAsync(seancesAdress).Result;
            if (response.StatusCode == HttpStatusCode.OK)
                return SeanceListCreator.CreateSeances(response);

            DialogMessage.ShowInfo("Błąd pobierania filmów!");
            return new List<Seance>();
        }
    }
}