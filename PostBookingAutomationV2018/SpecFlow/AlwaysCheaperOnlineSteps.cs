using System;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class AlwaysCheaperOnlineSteps
    {
        [BeforeScenario()]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.119.test/EN/secure/MyEasyJet.mvc/SignIn");
        }

        [Given(@"I have a booking")]
        public void GivenIHaveABooking()
        {
            


        }

        [When(@"I navigate to UpsellSeatPage in this '(.*)' language")]
        public void WhenINavigateToUpsellSeatPageInThisLanguage(string language)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the text will be '(.*)' as expected")]
        public void ThenTheTextWillBeAsExpected(string output)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
