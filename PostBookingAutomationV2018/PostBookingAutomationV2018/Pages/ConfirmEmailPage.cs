using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBookingAutomationV2018.Pages
{
    public class ConfirmEmailPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("a[href^='/EN/secure/MyEasyJet.mvc/ViewBooking?bookingReference=']");
        
        public ConfirmEmailPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[href^='/EN/secure/MyEasyJet.mvc/ViewBooking?bookingReference=']")] private IWebElement BackLink;


        public void ClickBackLink()
        {
            BackLink.Click();
        }
    }
}
