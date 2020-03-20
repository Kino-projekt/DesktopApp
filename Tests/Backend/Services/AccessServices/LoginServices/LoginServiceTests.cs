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
            loginService = LoginController.GetLoginService();
            loginService.SetConnectionService(new ConnectionServiceImitation());
        }

        [Test]
        public void LoginEmptyUser()
        {
            SetEmailAndPassword("","");
            Assert.IsFalse(loginService.LoginNewUser());
        }

        [Test]
        public void LoginWithEmptyEmail()
        {
            SetEmailAndPassword("", currectPassword);
            Assert.IsFalse(loginService.LoginNewUser());
        }

        [Test]
        public void LoginWithEmptyPassword()
        {
            SetEmailAndPassword(currectEmail, "");
            Assert.IsFalse(loginService.LoginNewUser());
        }

        [Test]
        public void LoginCurrectUserData()
        {
            SetEmailAndPassword(currectEmail, currectPassword);
            Assert.IsTrue(loginService.LoginNewUser());
        }

        private void SetEmailAndPassword(string email, string password)
        {
            loginService.SetUserEmail(email);
            loginService.SetUserPassword(password);
        }

    }
}