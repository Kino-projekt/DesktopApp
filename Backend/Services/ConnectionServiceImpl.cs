using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services
{
    public class ConnectionServiceImpl : ConnectionService
    {
        private static string SERVER_ADRESS = "https://afternoon-waters-37189.herokuapp.com/";

        private HttpClient client;

        public ConnectionServiceImpl()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(SERVER_ADRESS)
            };
        }

        public bool Singup(User user)
        {
            var content = createContent(user);
            HttpResponseMessage response = client.PostAsync("/api/auth/signup", content).Result;
            if (response.IsSuccessStatusCode)
            {
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