using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;

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
            return false;
        }

        public bool Singin(AuthData user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signin", content).Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                UserCreator.PutUserToSystem(response);
                return true;
            }
            return false;
        }

        public void SendArticle(Article article)
        {
            var content = ContentCreator.CreateContent(article);
            UserService userService = UserServiceImpl.GetInstance();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userService.GetUserToken());
            HttpResponseMessage response = client.PostAsync("/api/admin/articles", content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
            {
                ShowInfo("Ogłoszenie wysłane");
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                ShowInfo("Brak dostępu!");
            }
            else
            {
                ShowInfo("Błąd nieznany!");
            }
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

        private void ShowInfo(string message)
        {
            DialogResult dialog = dialog = MessageBox.Show(message, "Scruter", MessageBoxButtons.OK);
        }

    }
}