using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Data;

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

        public void SendArticle(User userData, Article article)
        {
            var content = ContentCreator.CreateContent(article);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userData.GetToken());
            HttpResponseMessage response = client.PostAsync("/api/articles", content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
            {

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

    }
}