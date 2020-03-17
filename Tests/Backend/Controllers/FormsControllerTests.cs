using DesktopApp.Backend.Services;
using DesktopApp.Backend.Controllers;
using NUnit.Framework;

namespace Tests.Backend.Controllers
{
    class FormsControllerTests
    {

        [Test]
        public void isOnlyOneServiceInstance()
        {
            FormService formServiceOne = FormsController.getFormService();
            FormService formServiceTwo = FormsController.getFormService();
            Assert.AreSame(formServiceOne, formServiceTwo);
        }
    }
}
