using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests
{

    [Binding]
    public class LinkGroupSteps : Baseclass, IDisposable 
    {
                

        [Given(@"I have opened the Home page")]
        public void GivenIHaveOpenedTheHomePage()
        {
            Homepage page = new Homepage(driver);
            page.UrlLaunch();
            wait(driver, 1000);
            page.Titlename();
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            Homepage page = new Homepage(driver);
            page.NavigateToSearchField();

        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string leeds0)
        {
            Homepage page = new Homepage(driver);
            page.NavigateToResult();
        }
        
        [Then(@"The search results are displayed")]
        [Obsolete("The search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
            Resultpage output = new Resultpage(driver);
            output.Searchtext();
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
