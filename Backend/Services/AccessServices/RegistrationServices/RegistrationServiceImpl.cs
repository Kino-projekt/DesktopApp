using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Controllers.Connection;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.AccessServices.RegistrationServices
{
    public class RegistrationServiceImpl : BasicAccessMethods, RegistrationService
    {

        public static RegistrationService GetService()
        {
            return new RegistrationServiceImpl();
        }

        private RegistrationServiceImpl()
        {
            SetConnectionController(ConnectionControllerImpl.GetController());
        }

        public bool RegisterNewUser()
        {
            if (CheckUserData())
                return GetConnectionController().Singup(GetAuthData());

            return false;
        }
    }
}