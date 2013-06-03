using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowTtrial.App
{
    public static class WebElementExtentions
    {
        public static void Type(this IWebElement element, string data)
        {
            element.Clear();
            element.SendKeys(data);
        }

        public static void SelectValue(this IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }
    }
}
