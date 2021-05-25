using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkGroup.DemoTests.PageClass
{
    public class JusitrictionResult
    {
        IWebDriver driver;

        public JusitrictionResult(IWebDriver _driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Justrictionname(string locatio)
        {
            string Jusitriction = driver.CurrentWindowHandle.ToString();
            switch (locatio)
            {
                case ("United Kingdom"):
                    Console.WriteLine("United Kingdom = " + Jusitriction);
                    Assert.AreEqual(Jusitriction, "CDwindow-C3B1E5A5DA2E19BA712A6207E38FA9E2");
                    break;
                case ("Switzerland"):
                    Console.WriteLine("Switzerland = " + Jusitriction);
                    Assert.AreEqual(Jusitriction, "CDwindow-07D301E4C91A86837BD5A8BDF9F3A7E6");
                    break;
                default:
                    Console.WriteLine("open window = " + Jusitriction);
                    break;
            }
        }
    }
}
