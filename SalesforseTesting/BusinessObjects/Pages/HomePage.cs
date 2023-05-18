using SalesforceTesting.BusinessObjects.Pages.Abstractions;
using SalesforceTesting.Service.Configurations;
using SalesforceTesting.Service.Selenium.Elements;

namespace SalesforceTesting.BusinessObjects.Pages
{
    public class HomePage : Page
    {
        private static string Url => SalesforseConfigurationManager.Urls.HomePage!;

        private readonly Link HomeLink = new("Home");

        public bool CheckUrlIsCorrect(string url)
        {
            return Url.Equals(url);
        }

        public bool CheckHomeLinkPresented()
        {
            return HomeLink.IsDisplayed();
        }
    }
}