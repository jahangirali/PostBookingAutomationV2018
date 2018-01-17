using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PostBookingAutomationV2018
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver; 

        [TestMethod]
        public void Initialize()
        {
            driver = new ChromeDriver();
            //driver.Url = "https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn";
            driver.Url = "https://www.119.test/TestPages/HomePage.html?lang=EN";

            driver.FindElement(By.CssSelector("div[a href='https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn']"));
        }

        public void EndTest()
        {
            driver.Quit();
        }
    }
}
