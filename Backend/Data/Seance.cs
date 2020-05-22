﻿using System.Diagnostics.PerformanceData;

namespace DesktopApp.Backend.Data
{
    public class Seance
    {
        private int id;
        private int movieId;
        private int hallId;
        private string date;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetMovieId(int id)
        {
            movieId = id;
        }

        public int GetMovieId()
        {
            return movieId;
        }

        public void SetHallId(int id)
        {
            hallId = id;
        }

        public int GetHallId()
        {
            return hallId;
        }

        public void SetDate(string date)
        {
            this.date = date;
        }

        public string GetDate()
        {
            return date;
        }
    }
}