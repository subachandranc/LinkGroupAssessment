using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests
{
    [Binding]
    public class JustrictionSteps : Baseclass, IDisposable
    {

        [When(@"I open the found solutions page")]
        public void WhenIOpenTheFoundSolutionsPage()
        {
            JustrictionHomepage Jud = new JustrictionHomepage(driver);
            Jud.UrlLaunch();
            Jud.CookieAccept();
        }

        [Then(@"I can select the (.*) Juristriction")]
        public void ThenICanSelectTheJuristriction(string locatio)
        {
            JustrictionHomepage Jud = new JustrictionHomepage(driver); 
            Jud.Justrictionname(locatio);
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
