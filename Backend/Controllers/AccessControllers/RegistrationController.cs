using DesktopApp.Backend.Services.AccessServices.RegistrationServices;

namespace DesktopApp.Backend.Controllers.AccessControllers
{
    public class RegistrationController
    {
        private static RegistrationService registrationService;

        public static RegistrationService GetRegistrationService()
        {
            return registrationService = new RegistrationServiceImpl();
        }
    }
}