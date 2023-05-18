using SalesforceTesting.BusinessObjects.Models.Utilities;
using SalesforceTesting.Tests.Abstractions;

namespace SalesforceTesting.Tests.TestFixtures
{
    [TestFixture]
    internal class LoginTests : SalesforseTests
    {
        [Test, Category("Positive"), Description("Login with valid account owner credentials check.")]
        public void Login_WithAccountOwnerValidCredentials()
        {
            var homePage = LoginPage!.Login(AccountOwnerBuilder.StandartAccountOwner);
            Assert.That(homePage.CheckHomeLinkPresented());
        }
    }
}