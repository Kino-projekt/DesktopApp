using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class RoleCreator
    {
        public static StringContent Create(Role role)
        {
            string myContent;
            if (role == Role.ADMIN)
            {
                myContent = JsonConvert.SerializeObject(new
                {
                    role = "CUSTOMER",
                });
            }
            else
            {
                myContent = JsonConvert.SerializeObject(new
                {
                    role = "ADMIN",
                });
            }
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}