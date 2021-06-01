using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
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
        public IWebElement Acceptcookie { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='nav-link dropdown-toggle']")]
        protected IWebElement Searchfield { get; set; }

        [FindsBy(How = How.Name, Using = "searchTerm")]
        protected IWebElement Search { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/header/div/div/div[2]/div/nav/div/ul/li[3]/div/form/button")]
        protected IWebElement SearchButton { get; set; }

        public void UrlLaunch()
        {
            GotoUrl(driver, "https://www.linkgroup.eu/");
        }

        public void Titlename()
        {
            string ActualTitle = driver.Title;
            Assert.IsFalse(driver.Title.ToLower().Contains("Home"));
        }

        
        public void NavigateToSearchField()
        {
            ClickAnElement(driver, Acceptcookie);
        }

        public Resultpage NavigateToResult()
        {
            if (Searchfield.Displayed)
            {
                ClickAnElement(driver, Searchfield);
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
