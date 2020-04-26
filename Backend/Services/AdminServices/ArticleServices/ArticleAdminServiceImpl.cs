using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.ArticleServices
{
    public class ArticleAdminServiceImpl : ArticleAdminService
    {
        private List<Article> articles;
        private AdminConnectionController connectionController;

        private ArticleAdminServiceImpl()
        {
            connectionController = AdminConnectionControllerImpl.GetController();
        }
        public static ArticleAdminService GetService()
        {
            return new ArticleAdminServiceImpl();
        }

        public void SendArticleToServer(Article article)
        {
            connectionController.SendArticle(article);
        }

        public void ChangeArticleStatus(Article article)
        {
            connectionController.ChangeArticleStatus(article);
        }

        public List<Article> GetArticleListForAdmin()
        {
            return articles = connectionController.GetAdminArticlesFromServer();
        }
    }
}