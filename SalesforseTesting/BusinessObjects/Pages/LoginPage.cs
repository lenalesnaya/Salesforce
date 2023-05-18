using Core.Selenium;
using OpenQA.Selenium;
using SalesforceTesting.BusinessObjects.Models;
using SalesforceTesting.BusinessObjects.Pages.Abstractions;
using SalesforceTesting.Service.Configurations;
using SalesforceTesting.Service.Selenium.Elements;

namespace SalesforceTesting.BusinessObjects.Pages
{
    public class LoginPage : Page
    {
        private static string Url => SalesforseConfigurationManager.Urls.LoginPage!;

        private readonly Input UsernameInput = new(By.Id("username"));
        private readonly Input PasswordInput = new(By.Id("password"));
        private readonly Button LoginButton = new("Login");

        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl(Url);
            return this;
        }

        public LoginPage TryToLogin(AccountOwner accountOwner)
        {
            SetUserName(accountOwner.Username!).
            SetPassword(accountOwner.Password!).
            ClickLoginButton();

            return this;
        }

        public HomePage Login(AccountOwner accountOwner)
        {
            TryToLogin(accountOwner);
            return new HomePage();
        }

        public LoginPage SetUserName(string username)
        {
            UsernameInput.Write(username);
            return this;
        }

        public LoginPage SetPassword(string password)
        {
            PasswordInput.Write(password);
            return this;
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public bool CheckUsernameInputPresented()
        {
            return UsernameInput.IsDisplayed();
        }

        public bool CheckUrlIsCorrect(string url)
        {
            return Url.Equals(url);
        }
    }
}