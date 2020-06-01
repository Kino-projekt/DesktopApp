using System.Net.Http;
using System.Text;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods
{
    public class ArticleCreator
    {
        public static StringContent Create(Article article)
        {
            string myContent = JsonConvert.SerializeObject(new
            {
                title = article.GetTitle(),
                description = article.GetDescription(),
            });
            return new StringContent(myContent, Encoding.UTF8, "application/json");
        }
    }
}