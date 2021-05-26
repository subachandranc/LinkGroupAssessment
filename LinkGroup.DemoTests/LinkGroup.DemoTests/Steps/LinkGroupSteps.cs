using System;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests
{

    [Binding]
    public class LinkGroupSteps : Baseclass, IDisposable 
    {
        IWebDriver driver;        

        [Given(@"I have opened the Home page")]
        public void GivenIHaveOpenedTheHomePage()
        {
            Homepage page = new Homepage(driver);
            page.UrlLaunch();
            Sleep(1000);
            page.Titlename();
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            Sleep(500);
            Homepage page = new Homepage(driver);
            page.NavigateToSearchField();

        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string leeds0)
        {
            StringSearch search = new StringSearch(driver);
            search.NavigateToResult();
        }

        [Then(@"The search results are displayed")]
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
