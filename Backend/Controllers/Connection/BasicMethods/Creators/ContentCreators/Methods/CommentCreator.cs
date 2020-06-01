using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class CommentCreator
    {
        public static StringContent Create(Comment comment)
        {
            string myContent = JsonConvert.SerializeObject(new
            {
                content = comment.GetContent(),
                movieId = comment.GetMovieId().ToString(),
            });
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}