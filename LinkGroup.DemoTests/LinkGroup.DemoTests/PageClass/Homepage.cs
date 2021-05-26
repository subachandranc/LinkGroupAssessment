using LinkGroup.DemoTests.Base_class;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace LinkGroup.DemoTests.Page_class
{
    public class Homepage : Baseclass
    {
        IWebDriver driver;

        public Homepage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        
        [FindsBy(How=How.XPath, Using = "//*[@class='cc-btn cc-dismiss']")]
        protected IWebElement Acceptcookie { get; set; }

        public void Titlename()
        { 
            Thread.Sleep(1000);
            string ActualTitle = driver.Title;
            string ExpectedTitle = "LinkGroup";
            Assert.IsTrue(ActualTitle.Equals(ExpectedTitle));
        }

        public StringSearch NavigateToSearchField()
        {
            Acceptcookie.Click();
            Thread.Sleep(1000)
            return new StringSearch(driver);
        }
    }
}
