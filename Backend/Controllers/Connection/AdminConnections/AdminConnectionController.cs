using System.Collections.Generic;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public interface AdminConnectionController
    {
        void SendArticle(Article article);
        List<Article> GetAdminArticlesFromServer();
        void ChangeArticleStatus(Article article);
        void DeleteArticle(Article article);


        List<User> GetUsersListFromServer();


        void SendMovie(Movie movie);

        List<Movie> GetMoviesListFromServer();
    }
}