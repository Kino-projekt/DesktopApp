using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection
{
    public interface ConnectionController
    {
        bool Singup(User user);
        bool Singin(User user);
        void SendArticle(UserData userData, Article article);
    }
}