using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public interface ArticleAdminConnection
    {
        void SendArticle(Article article);
        List<Article> DownloadArticles();
        void ChangeArticleStatus(Article article);
        void DeleteArticle(Article article);
    }
}