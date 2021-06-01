using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace LinkGroup.DemoTests
{
    public class Resultpage : Homepage
    {
		 
		 
        public Resultpage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchResults']/h3")]
        protected IWebElement resultText { get; set; }

        [Obsolete]
        public void Searchtext()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1500));
            wait.Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='SearchResults']/h3"))));
            string Actualresult = resultText.Text;
            string ExpectedSearch = "You searched for:\r\n" + '"' + "Leed" + '"';
            Assert.IsTrue(Actualresult.Equals(ExpectedSearch));
        }

    }
}
