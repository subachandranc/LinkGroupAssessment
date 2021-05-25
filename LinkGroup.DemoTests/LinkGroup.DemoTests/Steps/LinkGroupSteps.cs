using LinkGroup.DemoTests.Base_class;
using LinkGroup.DemoTests.Page_class;
using LinkGroup.DemoTests.PageClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests.Scenario
{
    [Binding]
    public class LinkGroupSteps : IDisposable
    {
        private IWebDriver driver;

        public LinkGroupSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            Homepage page = new Homepage(_driver);
        }


        [Given(@"I have opened the Home page")]
        public void GivenIHaveOpenedTheHomePage()
        {
            _driver.Navigate().GoToUrl("https://www.linkgroup.eu/");
            Homepage page = new Homepage(_driver);
            page.NavigateToSearchField();
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            Thread.Sleep(500);
            Homepage page = new Homepage(_driver);
            page.Titlename();

        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor()
        {
            StringSearch search = new StringSearch(_driver);
            search.NavigateToResult();
        }

        [Then(@"The search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
            Resultpage output = new Resultpage(_driver);
            output.Searchtext();
        }

        [When(@"I open the found solutions page")]
        public void WhenIOpenTheFoundSolutionsPage()
        {
            JustrictionHomepage Jud = new JustrictionHomepage(_driver);
            Jud.CookieAccept();
        }

        [Then(@"I can select the (.*) Juristriction")]
        public void ThenICanSelectTheJuristriction(string locatio)
        {
           JusitrictionResult Jus = new JusitrictionResult(_driver);
            Jus.Justrictionname(locatio);
        }

        public void Dispose()
        {
            if (_driver != null)
            {
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}
