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
        private ChromeDriver driver;

        public LinkGroupSteps()
        {
            driver = new ChromeDriver();
        }

        [Given(@"I have opened the Home page")]
        public void GivenIHaveOpenedTheHomePage()
        {
            driver.Navigate().GoToUrl("https://www.linkgroup.eu/");
			#URL launch
            driver.Manage().Window.Maximize();
            Thread.Sleep(1500);
            Assert.IsFalse(driver.Title.ToLower().Contains("LinkGroup"));
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            Thread.Sleep(500);
			#Accepting the cookie
            driver.FindElementByXPath("//*[@class='cc-btn cc-dismiss']").Click();

        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string leeds0)
        {
			#Search the string in search field
            driver.FindElementByXPath("//*[@class='nav-link dropdown-toggle']").Click();
            Thread.Sleep(1000);
            IWebElement search = driver.FindElementByName("searchTerm");
            search.SendKeys("Leed");
            Thread.Sleep(1000);
			#click the search button
            driver.FindElementByXPath("/html/body/div[3]/div/header/div/div/div[2]/div/nav/div/ul/li[3]/div/form/button").Click();
            Thread.Sleep(2000);
        }

        [Then(@"The search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
            #Finding result string
			string result = driver.FindElementByXPath("//*[@id='SearchResults']/h3").Text;
            Assert.AreEqual(result, "You searched for:\r\n" + '"' + "Leed" + '"');
        }

        [When(@"I open the found solutions page")]
        public void WhenIOpenTheFoundSolutionsPage()
        {
			#URL Launch
            driver.Navigate().GoToUrl("https://www.linkfundsolutions.co.uk/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1500);
            driver.FindElementByXPath("//*[@class='cc-btn cc-dismiss']").Click();
        }

        [Then(@"I can select the (.*) Juristriction")]
        public void ThenICanSelectTheJuristriction(string locatio)
        {
			#Get current Justriction URL 
            string Justriction = driver.CurrentWindowHandle;
            switch (locatio)
            {
                case ("United Kingdom"):
                    Console.WriteLine("United Kingdom = " + Justriction);
                    Assert.AreEqual(Justriction, "CDwindow-C3B1E5A5DA2E19BA712A6207E38FA9E2");
                    break;
                case ("Switzerland"):
                    Console.WriteLine("Switzerland = " + Justriction);
                    Assert.AreEqual(Justriction, "CDwindow-07D301E4C91A86837BD5A8BDF9F3A7E6");
                    break;
                default:
                    Console.WriteLine("open window = "+Justriction);
                    break;
            }
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
