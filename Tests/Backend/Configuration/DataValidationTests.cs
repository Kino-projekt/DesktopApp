using DesktopApp.Backend.Configuration;
using NUnit.Framework;

namespace Tests.Backend.Configuration
{
    public class DataValidationTests
    {
        [Test]
        public void SetEmptyPassword()
        {
            Assert.IsFalse(CheckPassword(""));
        }

        [Test]
        public void SetToSmallPassword()
        {
            Assert.IsFalse(CheckPassword("Sm2"));
        }

        [Test]
        public void SetToBigPassword()
        {
            Assert.IsFalse(CheckPassword("Sm2mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm"));
        }

        [Test]
        public void SetPasswordWithNoNumber()
        {
            Assert.IsFalse(CheckPassword("Password"));
        }

        [Test]
        public void SetPasswordWithNoBigChar()
        {
            Assert.IsFalse(CheckPassword("password4"));
        }

        [Test]
        public void SetPasswordWithNoSmallChar()
        {
            Assert.IsFalse(CheckPassword("PASSWORD4"));
        }

        [Test]
        public void SetCurrectPassword()
        {
            Assert.IsTrue(CheckPassword("Password4"));
        }

        private bool CheckPassword(string password)
        {
            return DataValidation.CheckPassword(password);
        }
    }
}