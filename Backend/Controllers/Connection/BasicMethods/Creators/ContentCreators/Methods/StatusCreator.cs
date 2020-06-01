using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class StatusCreator
    {
        public static StringContent Create(Status status)
        {
            string myContent;
            if (status == Status.Active)
            {
                myContent = JsonConvert.SerializeObject(new
                {
                    status = "INACTIVE",
                });
            }
            else
            {
                myContent = JsonConvert.SerializeObject(new
                {
                    status = "ACTIVE",
                });
            }
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}