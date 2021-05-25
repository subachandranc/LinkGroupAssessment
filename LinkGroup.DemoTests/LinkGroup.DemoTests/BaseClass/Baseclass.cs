using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LinkGroup.DemoTests.Base_class
{
    public class Baseclass
    {
        public IWebDriver driver;

        [SetUp]
        public  void Browserlaunch()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(1500);
        }

        [TearDown]
        public void close()
        {
            driver.Close();
        }
    }
}
