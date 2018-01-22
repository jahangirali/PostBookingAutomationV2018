using NUnit.Framework;
using PostBookingV2018.Pages;
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

            [Test]
            public void ViewAccountDetails()
            {
                var loginPage = new LoginPage(driver);
                loginPage.LoggedIn();

                var accountDetailsPage = new AccountDetailsPage(driver);
                accountDetailsPage.ClickAccountDetails();
            }

        }
    }
}
