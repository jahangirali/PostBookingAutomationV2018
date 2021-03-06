﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PostBookingV2018.Pages;
using Selenium.Pages;

namespace Selenium
{
    public static class LoginHelper
    {
        public static void LogIn(IWebDriver driver)
        {

            var loginPage = new LoginPage(driver);
            loginPage.LoggedIn();
        }

        public static void LogOut(IWebDriver driver)
        {
            var viewBookingPage = new ViewBookingsPage(driver);
            viewBookingPage.ClickLogOutButton();
        }
    }
}
