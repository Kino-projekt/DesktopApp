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

        void SendHall(Hall hall);
        List<Hall> GetHallsListFromServer();
        void DeleteHall(Hall hall);


        List<User> GetUsersListFromServer();
        void BanUser(User user);
        void ChangeUserRole(User user);


        void SendMovie(Movie movie);
        List<Movie> GetMoviesListFromServer();
        void DeleteMovie(Movie movie);

        void SendSeance(Seance seance);

        void DeleteSeance(Seance seance);
    }
}