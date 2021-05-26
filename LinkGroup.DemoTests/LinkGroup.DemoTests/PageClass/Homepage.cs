using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace LinkGroup.DemoTests
{
    public class Homepage : Baseclass
    {
        public Homepage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@class='cc-btn cc-dismiss']")]
        protected IWebElement Acceptcookie { get; set; }

        public void UrlLaunch()
        {
            GotoUrl(driver, "https://www.linkgroup.eu/");
            Sleep(1000);
        }

        public void Titlename()
        {
            string ActualTitle = driver.Title;
            string ExpectedTitle = "LinkGroup";
            Assert.IsTrue(ActualTitle.Equals(ExpectedTitle));
        }

        public StringSearch NavigateToSearchField()
        {
            ClickAnElement(driver, Acceptcookie);
            Sleep(1000);
            return new StringSearch(driver);
        }
    }
}
