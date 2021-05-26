using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LinkGroup.DemoTests
{
    public class StringSearch : Homepage
    {
        public StringSearch(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-link dropdown-toggle")]
        protected IWebElement Searchfield { get; set; }

        [FindsBy(How = How.Name, Using = "searchTerm")]
        protected IWebElement Search { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/header/div/div/div[2]/div/nav/div/ul/li[3]/div/form/button")]
        protected IWebElement SearchButton { get; set; }

        public Resultpage NavigateToResult()
        {
            if (Searchfield.Displayed)
            {
                Sleep(1500);
                ClickAnElement(driver, Searchfield);
                Sleep(1500);
                SendKeys(driver, Search, "Leed");
                ClickAnElement(driver, SearchButton);
                return new Resultpage(driver);
            }
            else
            {
                throw new NoSuchElementException("Searchfiled is not found");
            }    

        }

    }
}
