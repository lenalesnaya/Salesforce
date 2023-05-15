using Core.Selenium;
using OpenQA.Selenium;

namespace Service.Selenium.Elements
{
    internal class Button : Element
    {
        public Button(By locator) : base(locator) { }

        public Button(string locator) : base($"//input[@name='{locator}']") { }
    }
}