using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Services;
using DesktopApp.Backend.Services.UserServices;
using NUnit.Framework;

namespace Tests.Backend.Controllers
{
    public class UserControllerTests
    {
        [Test]
        public void isOnlyOneFormsServiceInstance()
        {
            UserService userServiceOne = UserController.GetUserService();
            UserService userServiceTwo = UserController.GetUserService();
            Assert.AreSame(userServiceOne, userServiceTwo);
        }
    }
}