using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Implementations;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.ArticleServices
{
    public class ArticleAdminServiceImpl : ArticleAdminService
    {
        private static ArticleAdminService adminService;
        private List<Article> articles;
        private ArticleAdminConnection connection;

        private ArticleAdminServiceImpl()
        {
            connection = new ArticleAdminConnectionImpl();
            DownloadArticleList();
        }
        public static ArticleAdminService GetService()
        {
            if(adminService==null)
                adminService = new ArticleAdminServiceImpl();
            return adminService;
        }

        public void SendArticle(Article article)
        {
            connection.SendArticle(article);
        }

        public void ChangeArticleStatus(Article article)
        {
            connection.ChangeArticleStatus(article);
        }

        public void DeleteArticle(Article article)
        {
            connection.DeleteArticle(article);
        }

        public void DownloadArticleList()
        {
            articles = connection.DownloadArticles();
        }

        public List<Article> GetArticleList()
        {
            if (articles == null)
                DownloadArticleList();
            return articles;
        }
    }
}