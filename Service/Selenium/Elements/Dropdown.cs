using Core.Selenium;
using OpenQA.Selenium;

namespace Service.Selenium.Elements
{
    internal class Dropdown : Element
    {
        public Dropdown(By locator) : base(locator) { }

        public Dropdown(string locator) :
            base($"//span[text()='{locator}']/ancestor::div[contains(@class, 'uiInput')]//a")
        { }

        public void Select(string option)
        {
            Browser.Driver.FindElement(Locator).Click();
            Browser.Driver.FindElement(By.CssSelector($"a[title='{option}']")).Click();
        }
    }
}