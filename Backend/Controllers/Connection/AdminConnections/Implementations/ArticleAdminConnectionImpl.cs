using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations
{
    public class ArticleAdminConnectionImpl : ArticleAdminConnection
    {
        public void SendArticle(Article article)
        {
            AdminPostMethods.Send(article);
        }

        public List<Article> DownloadArticles()
        {
            return AdminGetMethods.Articles();
        }

        public void ChangeArticleStatus(Article article)
        {
            AdminSpecificMethods.ChangeArticleStatus(article);
        }

        public void DeleteArticle(Article article)
        {
            AdminDeleteMethods.Delete(article);
        }
    }
}