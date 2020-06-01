using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class HallCreator
    {
        public static StringContent Create(Hall hall)
        {
            string myContent = JsonConvert.SerializeObject(new
            {
                name = hall.GetName(),
                countOfSeats = hall.GetSeats(),
            });
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}