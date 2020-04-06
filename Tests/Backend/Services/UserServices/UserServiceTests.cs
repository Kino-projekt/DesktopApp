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
            userService = UserServiceImpl.GetInstance();
        }

        [Test]
        public void PutNewUserToSystem()
        {
            userService.PutNewUser(new User());
            Assert.IsTrue(userService.GetUserStatus());
        }

    }
}