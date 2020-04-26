using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AdminServices.ArticleServices
{
    public interface ArticleAdminService
    {
        List<Article> GetArticleListForAdmin();

        void SendArticleToServer(Article article);

        void ChangeArticleStatus(Article article);
    }
}