using System.Threading;
using NUnit.Framework;
using Selenium;
using PostBookingV2018.Pages;
using Selenium.Pages;


namespace PostBookingV2018.Tests
{
    [TestFixture]
    public class LoginPageTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            LoginHelper.LogIn(driver);
        }

        [Test]
        public void ViewMyBookings()
        {
            
            var viewBookingsPage = new ViewBookingsPage(driver);
            viewBookingsPage.ClickMyBookings();

        }

        [Test]
        public void ViewAccountDetails()
        {

            var accountDetailsPage = new AccountDetailsPage(driver);
            accountDetailsPage.ClickAccountDetails();
        }

        [Test]
        public void EmailMeTheseDetails()
        {

            var viewBookingsPage = new ViewBookingsPage(driver);
            viewBookingsPage.ClickEmailMeTheseLink();
        }

        [Test]
        public void CheckInAllPassengers()
        {
            
            var viewBookingsPage = new ViewBookingsPage(driver);
            viewBookingsPage.ClickCheckInButton();
            Thread.Sleep(15);
            viewBookingsPage.ClickPrintAllBoardingPassesButton();
            

            var checkInPage = new CheckInPage(driver);
            checkInPage.ClickManageBookingsButton();
        }


        [TearDown]
        public void TearDown()
        {

            //driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn");
        }

    }
}

