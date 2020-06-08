using System.Net;
using System.Net.Http;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Forms.Notification;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods
{
    public class AdminDeleteMethods
    {
        private static void DeleteMethod(string patch, int id, string name)
        {
            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);
            string url = patch + "/" + id;
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            if (response.StatusCode == HttpStatusCode.NoContent)
                NotifitactionForm.ShowMessage("Usunięty element: "+name);
            else
                DialogMessage.ShowInfo("Błąd usuwania elemntu: "+name);
        }

        public static void Delete(Article article)
        {
            DeleteMethod(AdressList.ArticlesAdmin, article.GetId(), "Artykuł");
        }

        public static void Delete(Movie movie)
        {
            DeleteMethod(AdressList.MoviesAdmin, movie.GetId(), "Film");
        }

        public static void Delete(Hall hall)
        {
            DeleteMethod(AdressList.HallsAdmin, hall.GetId(), "Sala kinowa");
        }

        public static void Delete(Seance seance)
        {
            DeleteMethod(AdressList.SeancesAdmin, seance.GetId(), "Seans");
        }
    }
}