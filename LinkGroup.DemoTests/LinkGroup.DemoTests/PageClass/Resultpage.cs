using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LinkGroup.DemoTests.Page_class
{
    public class Resultpage : StringSearch
    {
        IWebDriver driver;

        public Resultpage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.XPath, Using= "//*[@id='SearchResults']/h3")]
        protected IWebElement resultText { get; set; }

        public void Searchtext()
        {
            Thread.Sleep(1500);
            string Actualresult = resultText.Text;
            string ExpectedSearch = "You searched for:\r\n" + '"' + "Leed" + '"';
            Assert.IsTrue(Actualresult.Equals(ExpectedSearch));
        }

    }
}
