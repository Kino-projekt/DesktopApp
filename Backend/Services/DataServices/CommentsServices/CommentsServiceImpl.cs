using DesktopApp.Backend.Controllers.Connection.UsersConnections;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.BookingServices;

namespace DesktopApp.Backend.Services.DataServices.CommentsServices
{
    public class CommentsServiceImpl : CommentsService
    {
        private UserConnectionController userConnection;

        private CommentsServiceImpl()
        {
            userConnection = new UserConnectionControllerImpl();
        }

        public static CommentsService GetService()
        {
            return new CommentsServiceImpl();
        }

        public void SendComment(Comment comment)
        {
            userConnection.SendComment(comment);
        }
    }
}