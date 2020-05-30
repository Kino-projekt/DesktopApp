using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
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
                seance.SetDate((string)seanceObject.date);
                seance.SetHall(createHall(seanceObject));
                seance.SetMovie(createMovie(seanceObject));

                seances.Add(seance);
            }
            return seances;
        }

        private static Movie createMovie(dynamic myObiect)
        {
            Movie movie = new Movie();
            movie.SetId((int)myObiect.movie.id);
            movie.SetTitle((string)myObiect.movie.title);
            movie.SetDescription((string) myObiect.movie.description);
            movie.SetDescription((string)myObiect.movie.director);

            return movie;
        }

        private static Hall createHall(dynamic myObiect)
        {
            Hall hall = new Hall();

            hall.SetId((int)myObiect.hallId);

            return hall;
        }
    }
}
