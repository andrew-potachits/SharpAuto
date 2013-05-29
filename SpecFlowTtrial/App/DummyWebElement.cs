using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;

namespace SpecFlowTtrial.App
{
    public class DummyWebElement : IWebElement
    {
        public IWebElement FindElement(By @by)
        {
            return new DummyWebElement();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            return new List<IWebElement>().AsReadOnly();
        }

        public void Clear()
        {
        }

        public void SendKeys(string text)
        {
        }

        public void Submit()
        {
        }

        public void Click()
        {
        }

        public string GetAttribute(string attributeName)
        {
            return string.Empty;
        }

        public string GetCssValue(string propertyName)
        {
            return string.Empty;
        }

        public string TagName { get; private set; }
        public string Text { get; private set; }
        public bool Enabled { get; private set; }
        public bool Selected { get; private set; }
        public Point Location { get; private set; }
        public Size Size { get; private set; }
        public bool Displayed { get; private set; }
    }
}