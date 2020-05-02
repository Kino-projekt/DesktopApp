using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.DataServices.ArticleServices;

namespace DesktopApp.Backend.Services.DataServices.ArticleServices
{
    public class ArticleServiceImpl : ArticleService
    {
        private static ArticleService articleService;
        private List<Article> articles;
        private ConnectionController connectionController;

        private ArticleServiceImpl()
        {
            connectionController = ConnectionControllerImpl.GetController();
            DownloadArticleList();
        }

        public static ArticleService GetService()
        {
            if(articleService==null)
                articleService = new ArticleServiceImpl();
            return articleService;
        }

        public List<Article> GetArticleList()
        {
            if(articles==null)
                DownloadArticleList();
            return articles;
        }

        public void DownloadArticleList()
        {
            articles = connectionController.GetArticlesFromServer();
        }
    }

}