using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public class AdminConnectionControllerImpl : AdminConnectionController
    {
        private HttpClient client;
        private string serverAdress = BasicConfiguration.GetServerAdress();
        private UserService userService;

        public static AdminConnectionController GetController()
        {
            return new AdminConnectionControllerImpl();
        }

        private AdminConnectionControllerImpl()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(serverAdress)
            };
            userService = UserServiceImpl.GetInstance();
        }

        public void SendArticle(Article article)
        {

            var content = ContentCreator.CreateContent(article);
            SetAuthorization();
            HttpResponseMessage response = client.PostAsync("/api/admin/articles", content).Result;
            if (response.StatusCode != HttpStatusCode.Created)
            {
                DialogMessage.ShowInfo("Błąd wysyłania!");
            }
        }

        public List<Article> GetAdminArticlesFromServer()
        {
            SetAuthorization();
            List<Article> articles;
            HttpResponseMessage response = client.GetAsync("/api/admin/articles").Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                articles = ArticleListCreator.CreateArticles(response);
                return articles;
            }

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return null;
        }

        public void ChangeArticleStatus(Article article)
        {
            SetAuthorization();
            string patchUrl = "/api/admin/articles/" + article.GetId() + "/status";
            var content = ContentCreator.CreateContent(article.GetStatus());
            HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), patchUrl)
            {
                Content = content
            }).Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                DialogMessage.ShowInfo("Błąd zmiany statusu!");
            }
        }

        public void DeleteArticle(Article article)
        {
            SetAuthorization();
            string patchUrl = "/api/admin/articles/" + article.GetId();
            HttpResponseMessage response = client.DeleteAsync(patchUrl).Result;
            if (response.StatusCode != HttpStatusCode.NoContent)
            {
                DialogMessage.ShowInfo("Błąd usuwania artykułu!");
            }
        }

        public List<User> GetUsersListFromServer()
        {
            List<User> users;
            HttpResponseMessage response = client.GetAsync("/api/users").Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                users = UsersListCreator.CreateUsers(response);
                return users;
            }

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return null;
        }

        public void SendMovie(Movie movie)
        {
            var content = ContentCreator.CreateContent(movie);
            SetAuthorization();
            HttpResponseMessage response = client.PostAsync("/api/admin/movies", content).Result;
            if (response.StatusCode != HttpStatusCode.Created)
            {
                DialogMessage.ShowInfo("Błąd wysyłania!");
            }
        }

        public List<Movie> GetMoviesListFromServer()
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

        private void SetAuthorization()
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", userService.GetUserToken());
        }

    }
}