using System.Net.Http;
using DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators.Methods;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.BasicMethods.Creators.ContentCreators
{
    public class ContentCreator
    {
        public static StringContent CreateContent(AuthData user)
        {
            return AuthDataCreator.Create(user);
        }

        public static StringContent CreateContent(Role role)
        {
            return RoleCreator.Create(role);
        }

        public static StringContent CreateContent(Article article)
        {
            return ArticleCreator.Create(article);
        }

        public static StringContent CreateContent(Status status)
        {
            return StatusCreator.Create(status);
        }

        public static StringContent CreateContent(Movie movie)
        {
            return MovieCreator.Create(movie);
        }

        public static StringContent CreateContent(Comment comment)
        {
            return CommentCreator.Create(comment);
        }

        public static StringContent CreateContent(Hall hall)
        {
            return HallCreator.Create(hall);
        }

        public static StringContent CreateContent(Seance seance)
        {
            return SeanceCreator.Create(seance);
        }
    }
}