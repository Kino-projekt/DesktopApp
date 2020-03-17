using DesktopApp.Backend.Services;
using DesktopApp.Backend.Controllers;
using NUnit.Framework;

namespace Tests.Backend.Controllers
{
    class FormsControllerTests
    {

        [Test]
        public void isOnlyOneFormsServiceInstance()
        {
            FormService formServiceOne = FormsController.GetFormService();
            FormService formServiceTwo = FormsController.GetFormService();
            Assert.AreSame(formServiceOne, formServiceTwo);
        }
    }
}
