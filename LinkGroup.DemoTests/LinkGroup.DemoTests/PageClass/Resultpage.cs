using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LinkGroup.DemoTests
{
    public class Resultpage : StringSearch
    {
        public Resultpage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchResults']/h3")]
        protected IWebElement resultText { get; set; }

        public void Searchtext()
        {
            Sleep(1500);
            string Actualresult = resultText.Text;
            string ExpectedSearch = "You searched for:\r\n" + '"' + "Leed" + '"';
            Assert.IsTrue(Actualresult.Equals(ExpectedSearch));
        }

    }
}
