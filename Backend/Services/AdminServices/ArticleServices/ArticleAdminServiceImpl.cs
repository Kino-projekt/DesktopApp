using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.ArticleServices
{
    public class ArticleAdminServiceImpl : ArticleAdminService
    {
        private static ArticleAdminService adminService;
        private List<Article> articles;
        private AdminConnectionController connectionController;

        private ArticleAdminServiceImpl()
        {
            connectionController = AdminConnectionControllerImpl.GetController();
            DownloadArticleList();
        }
        public static ArticleAdminService GetService()
        {
            if(adminService==null)
                adminService = new ArticleAdminServiceImpl();
            return adminService;
        }

        public void SendArticleToServer(Article article)
        {
            connectionController.SendArticle(article);
        }

        public void ChangeArticleStatus(Article article)
        {
            connectionController.ChangeArticleStatus(article);
        }

        public void DeleteArticle(Article article)
        {
            connectionController.DeleteArticle(article);
        }

        public void DownloadArticleList()
        {
            articles = connectionController.GetAdminArticlesFromServer();
        }

        public List<Article> GetArticleListForAdmin()
        {
            if (articles == null)
                DownloadArticleList();
            return articles;
        }
    }
}