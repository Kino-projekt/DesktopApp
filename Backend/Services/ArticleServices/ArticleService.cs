using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.ArticleServices
{
    public interface ArticleService
    {
        List<Article> GetArticleList();
        void SendArticleToServer(User user,Article article);
    }
}