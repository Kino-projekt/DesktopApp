using System.Diagnostics.PerformanceData;

namespace DesktopApp.Backend.Data
{
    public class Seance
    {
        private int id;
        private Movie movie;
        private Hall hall;
        private string date;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetMovie(Movie movie)
        {
            this.movie = movie;
        }

        public Movie GetMovie()
        {
            return movie;
        }

        public void SetHall(Hall hall)
        {
            this.hall = hall;
        }

        public Hall GetHall()
        {
            return hall;
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