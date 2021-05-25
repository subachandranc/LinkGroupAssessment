using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests.Page_class
{
    public class StringSearch
    {
        IWebDriver driver;

        public StringSearch(IWebDriver _driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-link dropdown-toggle")]
        public IWebElement Searchfield { get; set; }

        [FindsBy(How = How.Name, Using = "searchTerm")]
        public IWebElement Search { get; set; }

        [FindsBy(How=How.XPath, Using= "/html/body/div[3]/div/header/div/div/div[2]/div/nav/div/ul/li[3]/div/form/button")]
        public IWebElement SearchButton { get; set; }

        public Resultpage NavigateToResult()
        {
            Searchfield.Click();
            Search.SendKeys("Leed");
            SearchButton.Click();
            return new Resultpage(driver);

        }

    }
}
