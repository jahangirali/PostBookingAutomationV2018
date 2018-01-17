using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PostBookingAutomationV2018
{
    [TestClass]
    public class TestBase
    {
        IWebDriver driver; 

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn";
            //driver.Url = "https://www.119.test/TestPages/HomePage.html?lang=EN";

            //driver.FindElement(By.CssSelector("div[a href='https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn']"));


        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
