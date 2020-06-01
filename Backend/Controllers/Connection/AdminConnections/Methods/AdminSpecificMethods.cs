using System.Net;
using System.Net.Http;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Forms.Notification;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods
{
    public class AdminSpecificMethods
    {
        public static void ChangeArticleStatus(Article article)
        {
            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);

            string patchUrl = AdressList.ArticlesAdmin +"/"+ article.GetId() + "/status";
            var content = ContentCreator.CreateContent(article.GetStatus());
            HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), patchUrl)
            {
                Content = content
            }).Result;

            if (response.StatusCode != HttpStatusCode.OK)
                DialogMessage.ShowInfo("Błąd zmiany statusu!");
            else
                NotifitactionForm.ShowMessage("Status zmieniony!");
        }

        


        public static void BanUser(User user)
        {
            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);
            string patchUrl = AdressList.UsersAdmin + user.GetId() + "/ban";
            HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), patchUrl)).Result;

            if (response.StatusCode != HttpStatusCode.NoContent)
                DialogMessage.ShowInfo("Problem z banowaniem!");
            else if (response.StatusCode == HttpStatusCode.Forbidden)
                DialogMessage.ShowInfo("Nie można banować administratorów!");
            else
                NotifitactionForm.ShowMessage("Użytkownik zbanowany!");
        }

        public static void ChangeUserRole(User user)
        {
            HttpClient client = AdressList.GetHttpClient();
            AdminAuthorization.SetAuthorization(client);
            string patchUrl = AdressList.UsersAdmin + user.GetId() + "/update-role";
            var content = ContentCreator.CreateContent(user.GetRole());
            HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), patchUrl)
            {
                Content = content
            }).Result;

            if (response.StatusCode != HttpStatusCode.OK)
                DialogMessage.ShowInfo("Problem ze zmianą statusu!");
            else
                NotifitactionForm.ShowMessage("Status zmieniony!");
        }
    }
}