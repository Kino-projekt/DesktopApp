using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Services.ConnectionServices
{
    public class ConnectionServiceImpl : ConnectionService
    {
        private HttpClient client;
        private string serverAdress = BasicConfiguration.GetServerAdress();

        public ConnectionServiceImpl()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(serverAdress)
            };
        }

        public bool Singup(User user)
        {
            var content = createContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signup", content).Result;
            if (response.IsSuccessStatusCode)
            {
                // Get response from server in future
                return true;
            }
            return false;
        }

        public bool Singin(User user)
        {
            var content = createContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signin", content).Result;
            if (response.IsSuccessStatusCode)
            {

                // Get response from server in future
                string tokenBody =  response.Content.ReadAsStringAsync().Result;
                dynamic stuff = JsonConvert.DeserializeObject(tokenBody);
                string token = stuff.accessToken;
                
                UserData userData = new UserData();
                userData.SetEmail(user.GetEmail());
                userData.SetToken(token);

                UserService userService = UserController.GetUserService();
                userService.PutNewUser(userData);
                return true;
            }
            return false;
        }

        public void SendArticle(UserData userData, Article article)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("title", article.GetTitle()),
                new KeyValuePair<string, string>("description", article.GetDescription())
            };
            FormUrlEncodedContent content = new FormUrlEncodedContent(pairs);
            
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userData.GetToken());
            HttpResponseMessage response = client.PostAsync("/api/articles", content).Result;

            if (response.IsSuccessStatusCode)
            {

            }
        }

        private FormUrlEncodedContent createContent(User user)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("email", user.GetEmail()),
                new KeyValuePair<string, string>("password", user.GetPassword())
            };
            FormUrlEncodedContent content =new FormUrlEncodedContent(pairs);
            return content;
        }
    }
}