using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods
{
    public class UserCreator
    {
        public static void PutUserToSystem(HttpResponseMessage response)
        {
            string body = response.Content.ReadAsStringAsync().Result;
            List<Object> objects = JsonConvert.DeserializeObject<List<Object>>(body);

            User user = CreateUser(objects);
            SendUserToSystem(user);
        }

        private static User CreateUser(List<Object> objects)
        {
            dynamic userObject = objects[0];
            dynamic tokenObject = objects[1];

            User user = new User();

            dynamic email = userObject.email;
            string userEmail = email;
            user.SetEmail(userEmail);

            dynamic role = userObject.role;
            string userRole = role;
            user.SetRole(userRole);

            dynamic token = tokenObject.accessToken;
            string userToken = token;
            user.SetToken(userToken);

            return user;
        }
        private static void SendUserToSystem(User user)
        {
            UserService userService = UserServiceImpl.GetInstance();
            userService.PutNewUser(user);
        }
    }
}