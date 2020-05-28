using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.StandardConnections.Methods
{
    public class GetMethods
    {

        public static List<Article> Articles()
        {
            HttpResponseMessage response = GetFromServer(AdressList.Articles);
            if (response.StatusCode == HttpStatusCode.OK)
                return ArticleListCreator.CreateArticles(response);
            else
                return new List<Article>();
        }

        public static List<Movie> Movies()
        {
            HttpResponseMessage response = GetFromServer(AdressList.Movies);
            if (response.StatusCode == HttpStatusCode.OK)
                return MoviesListCreator.CreateMovies(response);
            else
                return new List<Movie>();
        }

        public static List<Hall> Halls()
        {
            HttpResponseMessage response = GetFromServer(AdressList.Halls);
            if (response.StatusCode == HttpStatusCode.OK)
                return HallsListCreator.CreateHalls(response);
            else
                return new List<Hall>();
        }

        public static List<Seance> Seances()
        {
            HttpResponseMessage response = GetFromServer(AdressList.Seances);
            if (response.StatusCode == HttpStatusCode.OK)
                return SeanceListCreator.CreateSeances(response);
            else
                return new List<Seance>();
        }

        private static HttpResponseMessage GetFromServer(string adress)
        {
            return AdressList.GetHttpClient().GetAsync(adress).Result;
        }
    }
}