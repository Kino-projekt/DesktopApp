using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.ArticleServices
{
    public interface ArticleAdminService
    {
        List<Article> GetArticleList();

        void SendArticle(Article article);

        void ChangeArticleStatus(Article article);

        void DeleteArticle(Article article);

        void DownloadArticleList();
    }
}