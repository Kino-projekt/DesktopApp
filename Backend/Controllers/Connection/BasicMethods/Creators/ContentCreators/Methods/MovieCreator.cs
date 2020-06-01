using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class MovieCreator
    {
        public static StringContent Create(Movie movie)
        {
            string myContent = JsonConvert.SerializeObject(new
            {
                title =movie.GetTitle(),
                description = movie.GetDescription(),
                director = movie.GetDirector(),
            });
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}