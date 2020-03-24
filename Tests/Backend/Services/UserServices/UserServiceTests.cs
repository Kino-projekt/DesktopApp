using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;
using NUnit.Framework;

namespace Tests.Backend.Services.UserServices
{
    public class UserServiceTests
    {
        private UserService userService;

        [SetUp]
        public void Setup()
        {
            userService = UserController.GetUserService();
        }

        [Test]
        public void UserIsNullOnStart()
        {
            Assert.IsFalse(userService.GetUserStatus());
        }

    }
}