using NUnit.Framework;
using PostBookingV2018.Pages;
using PostBookingAutomationV2018.Pages;


namespace PostBookingV2018.Tests
{
    [TestFixture]
    public class LoginPageTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoggedIn();
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
        public void CheckIn()
        {
            
            var viewBookingsPage = new ViewBookingsPage(driver);
            viewBookingsPage.ClickCheckInButton();

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

