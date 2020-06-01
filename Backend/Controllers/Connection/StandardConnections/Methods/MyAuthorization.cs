using System.Net;
using System.Net.Http;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.SaveServices;
using DesktopApp.Forms.Notification;

namespace DesktopApp.Backend.Controllers.Connection.StandardConnections.Methods
{
    public class MyAuthorization
    {
        public static bool SingUp(AuthData user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = AdressList.GetHttpClient().PostAsync(AdressList.SingUp, content).Result;
            if (response.StatusCode == HttpStatusCode.Created)
            {
                NotifitactionForm.ShowMessage("Użytkownik zarejestrowany!");
                return true;
            }

            DialogMessage.ShowInfo("Rejestracja nieudana!");
            return false;
        }

        public static bool SingIn(AuthData user)
        {
            var content = ContentCreator.CreateContent(user);
            HttpResponseMessage response = AdressList.GetHttpClient().PostAsync(AdressList.SingIn, content).Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MainUserCreator.PutUserToSystem(response);
                SaveService.SaveUser(user);
                return true;
            }
            DialogMessage.ShowInfo("Logowanie nieudane!");
            return false;
        }

    }
}