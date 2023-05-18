using Core.Selenium;
using OpenQA.Selenium;

namespace SalesforceTesting.Service.Selenium.Elements
{
    public class Input : Element
    {
        public Input(By locator) : base(locator) { }

        public Input(string locator) :
            base($"//span[text()='{locator}']/ancestor::div[contains(@class, 'uiInput')]//input")
        { }

        public void Write(string message)
        {
            Browser.Instance.Driver.FindElement(Locator).SendKeys(message);
        }
    }
}