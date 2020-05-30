using System.Collections;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.BookingServices
{
    public interface BookingService
    {
        void BookingSeats(Seance seance, ArrayList number);
    }
}