using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using DesktopApp.Forms.Notification;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods
{
    public class AdminPostMethods
    {
        private static void PostMethod(string patch, dynamic content, string name)
        {
            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);
            HttpResponseMessage response = client.PostAsync(patch, content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
                NotifitactionForm.ShowMessage("Wysłany element: "+name);
            else
                DialogMessage.ShowInfo("Błąd wysyłania elementu: "+name);
        }

        public static void Send(Article article)
        {
            var content = ContentCreator.CreateContent(article);
            PostMethod(AdressList.ArticlesAdmin, content, "Artykuł");
        }

        public static void Send(Movie movie)
        {
            var content = ContentCreator.CreateContent(movie);
            PostMethod(AdressList.MoviesAdmin, content, "Film");
        }

        public static void Send(Hall hall)
        {
            var content = ContentCreator.CreateContent(hall);
            PostMethod(AdressList.HallsAdmin, content, "Sala kinowa");
        }

        public static void Send(Seance seance)
        {
            var content = ContentCreator.CreateContent(seance);
            PostMethod(AdressList.SeancesAdmin, content, "Seans");
        }

    }
}