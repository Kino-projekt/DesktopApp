using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using DesktopApp.Forms.Notification;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public class AdminConnectionControllerImpl : AdminConnectionController
    {
        private HttpClient client;
        private string serverAdress = BasicConfiguration.GetServerAdress();
        private UserService userService;

        private string articlesAdminAdress = "/api/admin/articles";
        private string moviesAdminAdress = "/api/admin/movies";
        private string moviesAdress = "/api/movies";
        private string usersAdress = "/api/users";

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

        private void SetAuthorization()
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", userService.GetUserToken());
        }





        private bool PostMethod(string patch, dynamic content)
        {
            SetAuthorization();
            HttpResponseMessage response = client.PostAsync(patch, content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
                return true;
            return false;
        }

        public void SendArticle(Article article)
        {
            var content = ContentCreator.CreateContent(article);
            if (PostMethod(articlesAdminAdress, content))
                NotifitactionForm.ShowMessage("Ogłoszenie wysłane!");
            else
                DialogMessage.ShowInfo("Błąd wysyłania!");
        }

        public void SendMovie(Movie movie)
        {
            var content = ContentCreator.CreateContent(movie);
            if (PostMethod(moviesAdminAdress, content))
                NotifitactionForm.ShowMessage("Film wysłany!");
            else
                DialogMessage.ShowInfo("Błąd wysyłania!");
        }





        private HttpResponseMessage GetMethod(string patch)
        {
            SetAuthorization();
            return client.GetAsync(patch).Result;
        }

        public List<User> GetUsersListFromServer()
        {
            HttpResponseMessage response = GetMethod(usersAdress);
            if (response.StatusCode == HttpStatusCode.OK)
                return UsersListCreator.CreateUsers(response);

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return null;
        }

        public List<Article> GetAdminArticlesFromServer()
        {
            HttpResponseMessage response = GetMethod(articlesAdminAdress);
            if (response.StatusCode == HttpStatusCode.OK)
                return ArticleListCreator.CreateArticles(response);

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return null;
        }

        public List<Movie> GetMoviesListFromServer()
        {
            HttpResponseMessage response = GetMethod(moviesAdress);
            if (response.StatusCode == HttpStatusCode.OK)
                return MoviesListCreator.CreateMovies(response);

            DialogMessage.ShowInfo("Błąd pobierania filmów!");
            return null;
        }





        private bool DeleteMethod(string patch, int id)
        {
            SetAuthorization();
            string url = articlesAdminAdress + "/"+ id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if (response.StatusCode == HttpStatusCode.NoContent)
                return true;
            return false;
        }

        public void DeleteArticle(Article article)
        {
            if (DeleteMethod(articlesAdminAdress, article.GetId()))
                NotifitactionForm.ShowMessage("Ogłoszenie usunięte!");
            else
                DialogMessage.ShowInfo("Błąd usuwania artykułu!");
        }

        public void DeleteMovie(Movie movie)
        {
            if (DeleteMethod(moviesAdminAdress, movie.GetId()))
                NotifitactionForm.ShowMessage("Film usunięty!");
            else
                DialogMessage.ShowInfo("Błąd usuwania filmu!");
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
                DialogMessage.ShowInfo("Błąd zmiany statusu!");
            else
                NotifitactionForm.ShowMessage("Status zmieniony!");
        }
    }
}