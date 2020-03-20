using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Data;


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