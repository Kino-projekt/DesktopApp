using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class AuthDataCreator
    {
        public static StringContent Create(AuthData user)
        {
            string myContent = JsonConvert.SerializeObject(new
            {
                email = user.GetEmail(),
                password = user.GetPassword(),
            });
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}