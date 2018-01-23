using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBookingAutomationV2018.Pages
{
    public class ViewBookingsPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("a[id='YourBookingsLinkBreadcrumb']");

        public ViewBookingsPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[id='YourBookingsLinkBreadcrumb']")] private IWebElement AllBookings;
        [FindsBy(How = How.CssSelector, Using = "a[id='emailBookingLink']")] private IWebElement EmailMeTheseLink;
        [FindsBy(How = How.CssSelector, Using = "button[name='BoardingPassAndCheckin']")] private IWebElement BoardingPassCheckInButton;

        public void ClickMyBookings()
        {
            Thread.Sleep(10);
            AllBookings.Click();
        }

        public void ClickEmailMeTheseLink()
        {
            //EmailMeTheseLink.Click();
            Driver.Navigate().Back();
           
        }

        public void ClickCheckInButton()
        {
            BoardingPassCheckInButton.Click();
        }
    }
   
}

