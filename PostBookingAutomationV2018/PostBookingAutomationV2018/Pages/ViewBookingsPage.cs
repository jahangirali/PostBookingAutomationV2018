﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            
        }

        [FindsBy(How = How.CssSelector, Using = "YourBookingsLinkBreadcrumb")] private IWebElement AllBookings;

        public void ClickMyBookings()
        {
            AllBookings.Click();
        }
    }
   
}

