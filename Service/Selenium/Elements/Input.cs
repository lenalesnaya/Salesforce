using Core.Selenium;
using OpenQA.Selenium;

namespace Service.Selenium.Elements
{
    internal class Input : Element
    {
        public Input(By locator) : base(locator) { }

        public Input(string locator) :
            base($"//span[text()='{locator}']/ancestor::div[contains(@class, 'uiInput')]//input")
        { }
    }
}