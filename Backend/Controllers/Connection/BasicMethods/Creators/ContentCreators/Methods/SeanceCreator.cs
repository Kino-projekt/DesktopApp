using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class SeanceCreator
    {
        public static StringContent Create(Seance seance)
        {
            string myContent = JsonConvert.SerializeObject(new
            {
                movieId = seance.GetMovie().GetId().ToString(),
                hallId = seance.GetHall().GetId().ToString(),
                date = seance.GetDate(),
            });
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}