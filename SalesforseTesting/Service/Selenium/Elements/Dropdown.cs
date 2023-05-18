using Core.Selenium;
using OpenQA.Selenium;

namespace SalesforceTesting.Service.Selenium.Elements
{
    public class Dropdown : Element
    {
        public Dropdown(By locator) : base(locator) { }

        public Dropdown(string locator) :
            base($"//span[text()='{locator}']/ancestor::div[contains(@class, 'uiInput')]//a")
        { }

        public void Select(string option)
        {
            Browser.Instance.Driver.FindElement(Locator).Click();
            Browser.Instance.Driver.FindElement(By.CssSelector($"a[title='{option}']")).Click();
        }
    }
}