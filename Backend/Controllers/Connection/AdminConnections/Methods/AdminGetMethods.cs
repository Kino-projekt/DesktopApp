using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods
{
    public class AdminGetMethods
    {
        private static HttpResponseMessage GetMethod(string patch)
        {
            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);
            return client.GetAsync(patch).Result;
        }

        public static List<User> Users()
        {
            HttpResponseMessage response = GetMethod(AdressList.Users);
            if (response.StatusCode == HttpStatusCode.OK)
                return UsersListCreator.CreateUsers(response);
            else
                return new List<User>();
        }

        public static List<Article> Articles()
        {
            HttpResponseMessage response = GetMethod(AdressList.ArticlesAdmin);
            if (response.StatusCode == HttpStatusCode.OK)
                return ArticleListCreator.CreateArticles(response);
            else 
                return new List<Article>();
        }

        public static List<Movie> Movies()
        {
            HttpResponseMessage response = GetMethod(AdressList.Movies);
            if (response.StatusCode == HttpStatusCode.OK)
                return MoviesListCreator.CreateMovies(response);
            else
                return new List<Movie>();
        }
        public static List<Hall> Halls()
        {
            HttpResponseMessage response = GetMethod(AdressList.Halls);
            if (response.StatusCode == HttpStatusCode.OK)
                return HallsListCreator.CreateHalls(response);
            else
                return new List<Hall>();
        }

        public static List<Seance> Seances()
        {
            HttpResponseMessage response = GetMethod(AdressList.Seances);
            if (response.StatusCode == HttpStatusCode.OK)
                return SeanceListCreator.CreateSeances(response);
            else
                return new List<Seance>();
        }
    }
}