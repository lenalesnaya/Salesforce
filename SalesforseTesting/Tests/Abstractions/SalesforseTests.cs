using Core.Selenium;
using SalesforceTesting.BusinessObjects.Pages;

namespace SalesforceTesting.Tests.Abstractions
{
    internal abstract class SalesforseTests : Test
    {
        protected LoginPage? LoginPage { get; } = new();

        [SetUp]
        public void SetUpLoginPage()
        {
            LoginPage!.OpenPage();
        }
    }
}