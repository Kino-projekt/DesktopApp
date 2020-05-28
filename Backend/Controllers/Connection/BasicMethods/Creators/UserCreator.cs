using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
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

            user.SetEmail((string) userObject.email);

            dynamic role = userObject.role;
            string userRole = role;
            if (userRole == "ADMIN")
            {
                user.SetRole(Role.ADMIN);
            }
            else
            {
                user.SetRole(Role.CUSTOMER);

            }

            user.SetToken((string)tokenObject.accessToken);

            return user;
        }
        private static void SendUserToSystem(User user)
        {
            UserService userService = UserServiceImpl.GetInstance();
            userService.PutNewUser(user);
        }
    }
}