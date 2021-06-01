using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests
{
    public class Baseclass
    {
        public IWebDriver driver;
        
        [BeforeScenario]
        public void Browserlaunch()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait(driver, 1000);
        }

        [AfterScenario]
        public void close()
        {
            driver.Close();
        }

        public static IWebDriver ClickAnElement( IWebDriver driver, IWebElement element)
        {
            element.Click();
            return driver;
        }

        public static IWebDriver SendKeys( IWebDriver driver, IWebElement element, string text)
        {
            element.SendKeys(text);
            return driver;
        }

        public static void wait(IWebDriver driver, int min)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(min);
        }

        public IWebDriver GotoUrl( IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            return driver;
        }
    }
}
