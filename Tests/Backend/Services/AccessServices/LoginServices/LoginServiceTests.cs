using DesktopApp.Backend.Controllers.AccessControllers;
using DesktopApp.Backend.Services.AccessServices.LoginServices;
using NUnit.Framework;
using Tests.Imitations;

namespace Tests.Backend.Services.AccessServices.LoginServices
{
    public class LoginServiceTests
    {
        private LoginService loginService;
        // currect data for validation
        private string currectEmail = "test@wp.pl";
        private string currectPassword = "Test123";

        [SetUp]
        public void Setup()
        {
            loginService = LoginServiceImpl.GetService();
            loginService.SetConnectionService(new ConnectionServiceImitation());
        }

        [Test]
        public void LoginEmptyUser()
        {
            Assert.IsFalse(loginService.LoginNewUser());
        }

        [Test]
        public void LoginWithEmptyEmail()
        {
            loginService.SetUserPassword(currectPassword);
            Assert.IsFalse(loginService.LoginNewUser());
        }

        [Test]
        public void LoginWithEmptyPassword()
        {
            loginService.SetUserEmail(currectEmail);
            Assert.IsFalse(loginService.LoginNewUser());
        }

        [Test]
        public void LoginCurrectUserData()
        {
            loginService.SetUserEmail(currectEmail);
            loginService.SetUserPassword(currectPassword);
            Assert.IsTrue(loginService.LoginNewUser());
        }

        

    }
}