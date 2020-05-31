using System.Collections;
using System.Net;
using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Forms.Notification;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DesktopApp.Backend.Controllers.Connection.UsersConnections
{
    public class UserConnectionControllerImpl : UserConnectionController
    {
        public void BookingSeats(Seance seance, ArrayList numbers)
        {
            string myContent = JsonConvert.SerializeObject(new
            {
                seanceId = (string) seance.GetId().ToString(),
                reservedSeats = numbers,
    });

            DialogMessage.ShowInfo("Post: " + myContent);
            var content = new StringContent(myContent, Encoding.UTF8, "application/json");

            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);
            HttpResponseMessage response = client.PostAsync(AdressList.Booking, content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
                NotifitactionForm.ShowMessage("Wysłany element: " + "Rezerwacja");
            else
                DialogMessage.ShowInfo("Błąd wysyłania elementu: " + "Rezerwacja");
        }

        public void SendComment(Comment comment)
        {
            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);
            var content = ContentCreator.CreateContent(comment);
            HttpResponseMessage response = client.PostAsync(AdressList.Comments, content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
                NotifitactionForm.ShowMessage("Wysłany element: " + "Komentarz");
            else
                DialogMessage.ShowInfo("Błąd wysyłania elementu: " + "Komentarz");
        }
    }
}