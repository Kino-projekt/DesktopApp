using System.Collections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.UsersConnections
{
    public interface UserConnectionController
    {
        void BookingSeats(Seance seance, ArrayList numbers);
    }
}