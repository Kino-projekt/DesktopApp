using DesktopApp.Backend.Services.DesingerServices;

namespace DesktopApp.Backend.Controllers
{
    public class DesingerController
    {
        private static DesingerService desingerService;

        public static DesingerService GetDesingerService()
        {
            if (desingerService == null)
            {
                desingerService = new DesingerServiceImpl();
            }

            return desingerService;
        }

    }
}