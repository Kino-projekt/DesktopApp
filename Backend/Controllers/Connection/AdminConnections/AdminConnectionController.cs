using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public interface AdminConnectionController
    {
        void SendArticle(Article article);
        List<Article> GetAdminArticlesFromServer();
        void ChangeArticleStatus(Article article);
    }
}