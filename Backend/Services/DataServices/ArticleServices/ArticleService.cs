using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.ArticleServices
{
    public interface ArticleService
    {
        List<Article> GetArticleList();

        void DownloadArticleList();
    }
}