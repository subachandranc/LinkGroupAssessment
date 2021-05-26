using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LinkGroup.DemoTests
{
    public class JustrictionHomepage : Baseclass
    {
        public JustrictionHomepage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@class='cc-btn cc-dismiss']")]
        public IWebElement Acceptcookie { get; set; }

        public StringSearch CookieAccept()
        {
            driver.Navigate().GoToUrl("https://www.linkfundsolutions.co.uk/");
            Acceptcookie.Click();
            return new StringSearch(driver);
        }
    }
}
