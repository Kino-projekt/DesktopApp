using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using Newtonsoft.Json;

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

        public bool Singup(User user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signup", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public bool Singin(User user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signin", content).Result;
            if (response.IsSuccessStatusCode)
            {
                string tokenBody = response.Content.ReadAsStringAsync().Result;
                dynamic stuff = JsonConvert.DeserializeObject(tokenBody);
                string token = stuff.accessToken;

                UserData userData = new UserData();
                userData.SetEmail(user.GetEmail());
                userData.SetToken(token);

                UserService userService = UserServiceImpl.GetInstance();
                userService.PutNewUser(userData);
                return true;
            }
            return false;
        }

        public void SendArticle(UserData userData, Article article)
        {
            var content = ContentCreator.CreateContent(article);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userData.GetToken());
            HttpResponseMessage response = client.PostAsync("/api/articles", content).Result;
            if (response.IsSuccessStatusCode) {}
        }

    }
}