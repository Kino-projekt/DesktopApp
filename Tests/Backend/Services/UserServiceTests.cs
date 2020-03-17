using System;
using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services;
using NUnit.Framework;
using Tests.Imitations;

namespace Tests.Backend.Services
{
    public class UserServiceTests
    {
        private UserService userService;

        [SetUp]
        public void Setup()
        {
            userService = UserController.GetUserService();
            userService.SetConnectionService(new ConnectionServiceImitation());
        }

        [Test]
        public void RegistrationEmptyUser()
        {
            Assert.IsFalse(userService.RegisterNewUser("", ""));
        }


    }
}