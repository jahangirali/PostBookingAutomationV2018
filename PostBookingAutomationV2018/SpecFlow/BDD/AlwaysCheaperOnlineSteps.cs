using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PostBookingV2018.Pages;
using Selenium.Pages;
using TechTalk.SpecFlow;


namespace PBSpecFlow.SpecFlow.BDD
{
    [Binding]
    public class AlwaysCheaperOnlineSteps
    {
        IWebDriver driver = new ChromeDriver();
        private string bookingRef { get; set; }

        [BeforeScenario()]
        public void Setup()
        {
            
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn");
        }

        [Given(@"I have a booking")]
        public void GivenIHaveABooking()
        {
           // IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn");
            

            var loginPage = new LoginPage(driver);
            loginPage.LoggedIn();

            driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/AllBookings");
            var viewBookingsPage = new ViewBookingsPage(driver);

            //viewBookingsPage.ClickMyBookings();
            //viewBookingsPage.ClickSelectSeatsButton();
            bookingRef = viewBookingsPage.GetFirstBookingRef();


        }
        
        [When(@"I navigate to UpsellSeatPage in this '(.*)' language")]
        public void WhenINavigateToUpsellSeatPageInThisLanguage(string language)
        {
            //ScenarioContext.Current.Pending();
            driver.Navigate().GoToUrl($"https://www.119.test/{language}/secure/SeatChange.mvc/ChangeSeats?bookingReference={bookingRef}#SeatsPanel:SeatSelector");
        }
        
        [Then(@"the text will be '(.*)' as expected")]
        public void ThenTheTextWillBeAsExpected(string expectedAlwaysCheaperText)
        {
            //ScenarioContext.Current.Pending();
        }

        [AfterScenario()]
        public void TearDown()
        {

            driver.Quit();
        }
    }
}
