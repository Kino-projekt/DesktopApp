using DesktopApp.Backend.Controllers.Connection.UsersConnections;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.BookingServices;

namespace DesktopApp.Backend.Services.DataServices.CommentsServices
{
    public class CommentsServiceImpl : CommentsService
    {
        private UserConnectionController connection;

        private CommentsServiceImpl()
        {
            connection = new UserConnectionControllerImpl();
        }

        public static CommentsService GetService()
        {
            return new CommentsServiceImpl();
        }

        public void SendComment(Comment comment)
        {
            connection.SendComment(comment);
        }
    }
}