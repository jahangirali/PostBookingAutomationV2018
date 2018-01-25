using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Internal;
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
            viewBookingsPage.ClickMyBookings();
            driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/ViewBooking?bookingReference=E1111HP");
            viewBookingsPage.ClickCheckInButton();
            Thread.Sleep(5);
            viewBookingsPage.ClickPrintAllBoardingPassesButton();
            

            var checkInPage = new CheckInPage(driver);
            checkInPage.ClickManageBookingsButton();
        }

        [Test]
        public void CheckImportantInformation()
        {
            var viewBookingsPage = new ViewBookingsPage(driver);
            viewBookingsPage.ClickImportantInformationLink();
            
        }

        [Test]
        public void ChangeName()
        {
            var viewBookingsPage = new ViewBookingsPage(driver);
            viewBookingsPage.ClickChangeNameButton();

            var changeNamePage = new ChangeNamePage(driver);
            changeNamePage.ChangeName();
        }

        [Test]
        public void LogOut()
        {
            LoginHelper.LogOut(driver);
        }

        [Test]
        public void CheckFlightStatus()
        {
            var viewBookingsPage = new ViewBookingsPage(driver);
            viewBookingsPage.ClickFlightStatus();
        }


        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
            //driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn");
        }

    }
}

