using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests.Page_class
{
    public class Resultpage
    {
        IWebDriver driver;

        public Resultpage(IWebDriver _driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.XPath, Using= "//*[@id='SearchResults']/h3")]
        protected IWebElement resultText { get; set; }

        public void Searchtext()
        {
            string Actualresult = resultText.Text;
            string ExpectedSearch = "You searched for:\r\n" + '"' + "Leed" + '"';
            Assert.IsTrue(Actualresult.Equals(ExpectedSearch));
        }

    }
}
