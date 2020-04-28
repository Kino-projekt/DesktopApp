using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.ArticleServices
{
    public class ArticleServiceImpl : ArticleService
    {
        private List<Article> articles;
        private ConnectionController connectionController;

        private ArticleServiceImpl()
        {
            connectionController = ConnectionControllerImpl.GetController();
        }

        public static ArticleService GetService()
        {
            return new ArticleServiceImpl();
        }

        public List<Article> GetArticleList()
        {
            if(articles==null)
                articles = connectionController.GetArticlesFromServer();
            return articles;
        }


    }
}