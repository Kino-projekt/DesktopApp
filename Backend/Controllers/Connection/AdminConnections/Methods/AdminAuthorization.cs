using System.Net.Http;
using System.Net.Http.Headers;
using DesktopApp.Backend.Services.UserServices;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods
{
    public class AdminAuthorization
    {
        public static void SetAuthorization(HttpClient client)
        {
             client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", UserServiceImpl.GetInstance().GetUserToken());
        }
    }
}