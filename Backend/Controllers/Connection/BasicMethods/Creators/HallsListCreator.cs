using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class HallsListCreator
    {
        public static List<Hall> CreateHalls(HttpResponseMessage response)
        {
            string body = response.Content.ReadAsStringAsync().Result;
            List<Object> objects = JsonConvert.DeserializeObject<List<Object>>(body);
            return DecodeList(objects);
        }

        private static List<Hall> DecodeList(List<Object> objects)
        {
            List<Hall> halls = new List<Hall>();

            for (int i = 0; i < objects.Count; i++)
            {
                Hall hall = new Hall();
                dynamic hallObject = objects[i];

                hall.SetId((int)hallObject.id);
                hall.SetName((string)hallObject.name);
                hall.SetSeats((int)hallObject.countOfSeats);

                halls.Add(hall);
            }
            return halls;
        }
    }
}