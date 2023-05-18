using Core.Selenium;
using OpenQA.Selenium;

namespace SalesforceTesting.Service.Selenium.Elements
{
    public class Link : Element
    {
        public Link(By locator) : base(locator) { }

        public Link(string locator) : base($"//a[@title='{locator}']") { }
    }
}