using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class SeanceListCreator
    {
        public static List<Seance> CreateSeances(HttpResponseMessage response)
        {
            string body = response.Content.ReadAsStringAsync().Result;
            List<Object> objects = JsonConvert.DeserializeObject<List<Object>>(body);
            return DecodeList(objects);
        }

        private static List<Seance> DecodeList(List<Object> objects)
        {
            List<Seance> seances = new List<Seance>();

            for (int i = 0; i < objects.Count; i++)
            {
                Seance seance = new Seance();
                dynamic seanceObject = objects[i];

                seance.SetId((int)seanceObject.id);
                seance.SetMovieId((int)seanceObject.movieId);
                seance.SetHallId((int)seanceObject.hallId);
                seance.SetDate((string)seanceObject.date);

                seances.Add(seance);
            }
            return seances;
        }
    }
}