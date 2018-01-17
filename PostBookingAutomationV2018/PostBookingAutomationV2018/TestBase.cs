using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PostBookingV2018
{
    
    public class TestBase
    {
        public IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn");
            //driver.Url = "https://www.119.test/TestPages/HomePage.html?lang=EN";

            //driver.FindElement(By.CssSelector("div[a href='https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn']"));

        }

        [TearDown]
        public void TearDown()
        {
            //driver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
