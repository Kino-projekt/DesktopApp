using System.Collections;
using DesktopApp.Backend.Controllers.Connection.UsersConnections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.BookingServices
{
    public class BookingServiceImpl : BookingService
    {
        private UserConnectionController userConnection;

        private BookingServiceImpl()
        {
            userConnection = new UserConnectionControllerImpl();
        }

        public static BookingService GetService()
        {
            return new BookingServiceImpl();
        }

        public void BookingSeats(Seance seance,ArrayList numbers)
        {
            userConnection.BookingSeats(seance, numbers);
        }
    }
}