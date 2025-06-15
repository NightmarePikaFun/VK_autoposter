using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_autoposter
{
    internal class WebDriverAction
    {
        IWebDriver webDriver;
        public void Initialize()
        {
            webDriver = new ChromeDriver();
        }

        public void ClickButton_ByClass(string buttonClassName)
        {
            var element = webDriver.FindElement(By.ClassName(buttonClassName)); 
            element.Click();
        }
        
        public void ClickButton_ByCssSelector(string selector)
        {
            var element = webDriver.FindElement(By.CssSelector(selector)); 
            element.Click();
        }

        public void OpenUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public void WriteText(string selector, string text)
        {
            var element = webDriver.FindElement(By.CssSelector(selector));
            element.SendKeys(text);
        }

        public void Wait(int timeMillis)
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(timeMillis);
        }
    }
}
