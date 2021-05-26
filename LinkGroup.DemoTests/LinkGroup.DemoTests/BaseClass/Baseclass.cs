using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            Sleep(1500);
        }

        [AfterScenario]
        public void close()
        {
            driver.Close();
        }

        public IWebDriver ClickAnElement(this IWebDriver driver, IWebElement element)
        {
            element.Click();
            return driver;
        }

        public IWebDriver SendKeys(this IWebDriver driver, IWebElement element, string text)
        {
            element.SendKeys(text);
            Sleep(200);
            return driver;
        }

        public void Sleep(int min)
        {
            Thread.Sleep(min);
        }

        public IWebDriver GotoUrl(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            Sleep(1500);
            return driver;
        }
    }
}
