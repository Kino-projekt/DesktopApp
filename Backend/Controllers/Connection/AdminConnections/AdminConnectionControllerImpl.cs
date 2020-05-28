using System.Collections.Generic;
using DesktopApp.Backend.Controllers.Connection.AdminConnections.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public class AdminConnectionControllerImpl : AdminConnectionController
    {
        public static AdminConnectionController GetController()
        {
            return new AdminConnectionControllerImpl();
        }

        public void SendArticle(Article article)
        {
            AdminPostMethods.Send(article);
        }

        public void SendMovie(Movie movie)
        {
            AdminPostMethods.Send(movie);
        }

        public void SendHall(Hall hall)
        {
            AdminPostMethods.Send(hall);
        }

        public void SendSeance(Seance seance)
        {
            AdminPostMethods.Send(seance);
        }

        public List<User> GetUsersListFromServer()
        {
            return AdminGetMethods.Users();
        }

        public List<Article> GetAdminArticlesFromServer()
        {
            return AdminGetMethods.Articles();
        }

        public List<Movie> GetMoviesListFromServer()
        {
            return AdminGetMethods.Movies();
        }
        public List<Hall> GetHallsListFromServer()
        {
            return AdminGetMethods.Halls();
        }

        public List<Seance> GetSeancesListFromServer()
        {
            return AdminGetMethods.Seances();
        }


        public void DeleteArticle(Article article)
        {
            AdminDeleteMethods.Delete(article);
        }

        public void DeleteMovie(Movie movie)
        {
            AdminDeleteMethods.Delete(movie);
        }

        public void DeleteHall(Hall hall)
        {
            AdminDeleteMethods.Delete(hall);
        }

        public void DeleteSeance(Seance seance)
        {
            AdminDeleteMethods.Delete(seance);
        }


        public void ChangeArticleStatus(Article article)
        {
            AdminSpecificMethods.ChangeArticleStatus(article);
        }

        public void BanUser(User user)
        {
            AdminSpecificMethods.BanUser(user);
        }

        public void ChangeUserRole(User user)
        {
            AdminSpecificMethods.ChangeUserRole(user);
        }
    }
}