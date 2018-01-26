using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
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
        [FindsBy(How = How.CssSelector, Using = "button[class='appear-clickable checkinButton orange-panel reprint-button-state']")] private IWebElement PrintAllBoardingPassButton;
        [FindsBy(How = How.CssSelector, Using = "a[title='Sign out']")] private IWebElement LogOutButton;
        [FindsBy(How = How.CssSelector, Using = "a[title='Sign out']")] private IWebElement ImportantInformationLink;
        [FindsBy(How = How.CssSelector, Using = "button[class='WhiteBlueButtonModern  ChangeFlight']")] private IWebElement ChangeFlightButton;
        [FindsBy(How = How.CssSelector, Using = "button[class='WhiteBlueButtonModern  ChangeName']")] private IWebElement ChangeNameButton;
        [FindsBy(How = How.CssSelector, Using = "button[class='WhiteBlueButtonModern  SelectSeats']")] private IWebElement SelectSeatsButton;
        [FindsBy(How = How.CssSelector, Using = "button[class='WhiteBlueButtonModern  AddHoldItems']")] private IWebElement AddHoldItemsButton;

        [FindsBy(How = How.CssSelector, Using = "a[href^='http://www.easyjet.com/en/flight-tracker/5500']")] private IWebElement CheckFlightStatus;



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

        public void ClickPrintAllBoardingPassesButton()
        {
            PrintAllBoardingPassButton.Click();
        }

        public void ClickImportantInformationLink()
        {
            ImportantInformationLink.Click();
        }

        public void ClickLogOutButton()
        {
            LogOutButton.Click();
        }

        public void ClickChangeFlightButton()
        {
            ChangeFlightButton.Click();
        }

        public void ClickChangeNameButton()
        {
            ChangeNameButton.Click();
        }

        public void ClickFlightStatus()
        {
            CheckFlightStatus.Click();
        }
    }
   
}

