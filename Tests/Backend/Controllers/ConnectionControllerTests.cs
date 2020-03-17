using DesktopApp.Backend.Controllers;
using DesktopApp.Backend.Services;
using NUnit.Framework;

namespace Tests.Backend.Controllers
{
    public class ConnectionControllerTests
    {
        [Test]
        public void isOnlyOneConnectionServiceInstance()
        {
            ConnectionService connectionServiceOne = ConnectionController.GetConnectionService();
            ConnectionService connectionServiceTwo = ConnectionController.GetConnectionService();
            Assert.AreSame(connectionServiceOne, connectionServiceTwo);
        }
    }
}