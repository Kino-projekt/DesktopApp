using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class UsersListCreator
    {
        public static List<User> CreateUsers(HttpResponseMessage response)
        {
            string body = response.Content.ReadAsStringAsync().Result;
            List<Object> objects = JsonConvert.DeserializeObject<List<Object>>(body);
            if (objects.Count == 0)
            {
                return null;
            }
            else
            {
                return DecodeList(objects);
            }
        }

        private static List<User> DecodeList(List<Object> objects)
        {
            List<User> users = new List<User>();
            int size = objects.Count;

            for (int i = 0; i < size; i++)
            {
                User user = new User();
                dynamic userObject = objects[i];

                user.SetId((int)userObject.id);
                user.SetEmail((string)userObject.email);

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

                users.Add(user);
            }
            return users;
        }
    }
}