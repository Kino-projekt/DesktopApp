using DesktopApp.Backend.Services.AccessServices.LoginServices;
using DesktopApp.Backend.Services.AccessServices.RegistrationServices;
using NUnit.Framework;
using Tests.Imitations;

namespace Tests.Backend.Services.AccessServices.RegistrationServices
{
    public class RegistrationServiceTests
    {
        private RegistrationService registrationService;
        // currect data for validation
        private string currectEmail = "test@wp.pl";
        private string currectPassword = "Test123";

        [SetUp]
        public void Setup()
        {
            registrationService = RegistrationServiceImpl.GetService();
            registrationService.SetConnectionController(new ConnectionControllerImitation());
        }

        [Test]
        public void RegisterEmptyUser()
        {
            Assert.IsFalse(registrationService.RegisterNewUser());
        }

        [Test]
        public void RegisterWithEmptyEmail()
        {
            registrationService.SetUserPassword(currectPassword);
            Assert.IsFalse(registrationService.RegisterNewUser());
        }

        [Test]
        public void RegisterWithEmptyPassword()
        {
            registrationService.SetUserEmail(currectEmail);
            Assert.IsFalse(registrationService.RegisterNewUser());
        }

        [Test]
        public void RegisterCurrectUserData()
        {
            registrationService.SetUserEmail(currectEmail);
            registrationService.SetUserPassword(currectPassword);
            Assert.IsTrue(registrationService.RegisterNewUser());
        }

    }
}