using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace Tests.Imitations
{
    public class ConnectionControllerImitation : ConnectionController
    {
        // imitation server connect for test, every method always return true

        public bool Singup(User user)
        {
            return true;
        }

        public bool Singin(User user)
        {
            return true;
        }

        public void SendArticle(UserData userData, Article article)
        {
        }
    }
}