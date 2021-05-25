using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LinkGroup.DemoTests.Page_class
{
    public class JustrictionHomepage
    {
        IWebDriver driver;

        public JustrictionHomepage(IWebDriver _driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@class='cc-btn cc-dismiss']")]
        protected IWebElement Acceptcookie { get; set; }

        public StringSearch CookieAccept()
        {
            driver.Navigate().GoToUrl("https://www.linkfundsolutions.co.uk/");
            Acceptcookie.Click();
            return new StringSearch(driver);
        }
    }
}
