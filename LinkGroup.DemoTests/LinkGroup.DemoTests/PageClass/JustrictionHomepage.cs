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

        public void UrlLaunch()
        {
            GotoUrl(driver, "https://www.linkfundsolutions.co.uk/");
            Sleep(1000);
        }

        public StringSearch CookieAccept()
        {
            ClickAnElement(driver, Acceptcookie);
            Sleep(1000);
            return new StringSearch(driver);
        }
    }
}
