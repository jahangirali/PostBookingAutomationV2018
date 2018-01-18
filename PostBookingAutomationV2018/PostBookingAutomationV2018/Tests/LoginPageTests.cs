using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using PostBookingV2018.Pages;
using OpenQA.Selenium;
using PostBookingAutomationV2018.Pages;


namespace PostBookingV2018.Tests
{
    [TestFixture]
    public class LoginPageTests: TestBase
    {
        
        public class LoginTests: TestBase
        {
            [Test]
            public void ViewMyBookings()
            {
                var loginPage = new LoginPage(driver);

                loginPage.LoggedIn();

                var viewBookingsPage = new ViewBookingsPage(driver);
                viewBookingsPage.ClickMyBookings();

            }

        }
    }
}
