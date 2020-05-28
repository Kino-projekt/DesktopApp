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
using DesktopApp.Forms.Notification;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public class AdminConnectionControllerImpl : AdminConnectionController
    {
        private HttpClient client;
        private UserService userService;


        public static AdminConnectionController GetController()
        {
            return new AdminConnectionControllerImpl();
        }

        private AdminConnectionControllerImpl()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(AdressList.Server)
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
            if (PostMethod(AdressList.ArticlesAdmin, content))
                NotifitactionForm.ShowMessage("Ogłoszenie wysłane!");
            else
                DialogMessage.ShowInfo("Błąd wysyłania!");
        }

        public void SendMovie(Movie movie)
        {
            var content = ContentCreator.CreateContent(movie);
            if (PostMethod(AdressList.MoviesAdmin, content))
                NotifitactionForm.ShowMessage("Film wysłany!");
            else
                DialogMessage.ShowInfo("Błąd wysyłania!");
        }

        public void SendHall(Hall hall)
        {
            var content = ContentCreator.CreateContent(hall);
            if(PostMethod(AdressList.HallsAdmin, content))
                NotifitactionForm.ShowMessage("Sala wysłana!");
            else
                DialogMessage.ShowInfo("Błąd wysyłania!");
        }

        public void SendSeance(Seance seance)
        {
            var content = ContentCreator.CreateContent(seance);
            if (PostMethod(AdressList.SeancesAdmin, content))
                NotifitactionForm.ShowMessage("Seans wysłany!");
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
            HttpResponseMessage response = GetMethod(AdressList.Users);
            if (response.StatusCode == HttpStatusCode.OK)
                return UsersListCreator.CreateUsers(response);

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return new List<User>();
        }

        public List<Article> GetAdminArticlesFromServer()
        {
            HttpResponseMessage response = GetMethod(AdressList.ArticlesAdmin);
            if (response.StatusCode == HttpStatusCode.OK)
                return ArticleListCreator.CreateArticles(response);

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return new List<Article>();
        }

        public List<Movie> GetMoviesListFromServer()
        {
            HttpResponseMessage response = GetMethod(AdressList.Movies);
            if (response.StatusCode == HttpStatusCode.OK)
                return MoviesListCreator.CreateMovies(response);

            DialogMessage.ShowInfo("Błąd pobierania filmów!");
            return new List<Movie>();
        }
        public List<Hall> GetHallsListFromServer()
        {
            HttpResponseMessage response = GetMethod(AdressList.Halls);
            if (response.StatusCode == HttpStatusCode.OK)
                return HallsListCreator.CreateHalls(response);

            DialogMessage.ShowInfo("Błąd pobierania filmów!");
            return new List<Hall>();
        }

        public List<Seance> GetSeancesListFromServer()
        {
            HttpResponseMessage response = client.GetAsync(AdressList.Seances).Result;
            if (response.StatusCode == HttpStatusCode.OK)
                return SeanceListCreator.CreateSeances(response);

            DialogMessage.ShowInfo("Błąd pobierania seansów!");
            return new List<Seance>();
        }





        private bool DeleteMethod(string patch, int id)
        {
            SetAuthorization();
            string url = AdressList.ArticlesAdmin + "/"+ id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if (response.StatusCode == HttpStatusCode.NoContent)
                return true;
            return false;
        }

        public void DeleteArticle(Article article)
        {
            if (DeleteMethod(AdressList.ArticlesAdmin, article.GetId()))
                NotifitactionForm.ShowMessage("Ogłoszenie usunięte!");
            else
                DialogMessage.ShowInfo("Błąd usuwania artykułu!");
        }

        public void DeleteMovie(Movie movie)
        {
            if (DeleteMethod(AdressList.MoviesAdmin, movie.GetId()))
                NotifitactionForm.ShowMessage("Film usunięty!");
            else
                DialogMessage.ShowInfo("Błąd usuwania filmu!");
        }

        public void DeleteHall(Hall hall)
        {
            if (DeleteMethod(AdressList.HallsAdmin, hall.GetId()))
                NotifitactionForm.ShowMessage("Sala usunięta!");
            else
                DialogMessage.ShowInfo("Błąd usuwania sali!");
        }

        public void DeleteSeance(Seance seance)
        {
            if (DeleteMethod(AdressList.SeancesAdmin, seance.GetId()))
                NotifitactionForm.ShowMessage("Seanse usunięty!");
            else
                DialogMessage.ShowInfo("Błąd usuwania seansu!");
        }






        public void ChangeArticleStatus(Article article)
        {
            SetAuthorization();
            string patchUrl = AdressList.ArticlesAdmin + article.GetId() + "/status";
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

        public void BanUser(User user)
        {
            SetAuthorization();
            string patchUrl = AdressList.UsersAdmin + user.GetId()+ "/ban";
            HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), patchUrl)).Result;

            if (response.StatusCode != HttpStatusCode.NoContent)
                DialogMessage.ShowInfo("Problem z banowaniem!");
            else if (response.StatusCode == HttpStatusCode.Forbidden)
                DialogMessage.ShowInfo("Nie można banować administratorów!");
            else
                NotifitactionForm.ShowMessage("Użytkownik zbanowany!");
        }

        public void ChangeUserRole(User user)
        {
            SetAuthorization();
            string patchUrl = AdressList.UsersAdmin + user.GetId() + "/update-role";
            var content = ContentCreator.CreateContent(user.GetRole());
            HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), patchUrl)
            {
                Content = content
            }).Result;

            if (response.StatusCode != HttpStatusCode.OK)
                DialogMessage.ShowInfo("Problem ze zmianą statusu!");
            else
                NotifitactionForm.ShowMessage("Status zmieniony!");
        }
    }
}