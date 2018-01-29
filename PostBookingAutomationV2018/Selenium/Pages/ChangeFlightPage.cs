using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Pages
{
    public class ChangeFlightPage
    {
        private IWebDriver Driver { get; }
        

        public ChangeFlightPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "select[id='oDay']")] private IWebElement FlyingOutDay;
        [FindsBy(How = How.CssSelector, Using = "select[id='oMonYear']")] private IWebElement FlyingOutMonthYear;
        [FindsBy(How = How.CssSelector, Using = "input[id='continueButton']")] private IWebElement SearchNewFlightsButton;
        [FindsBy(How = How.CssSelector, Using = "input[class='buttonNavigation Back buttonBackAction']")] private IWebElement BackButton;

        public void EnterFlightDetails()
        {
            EnterFlyingOutDay("28");
            EnterFlyingOutMonthYear("022018");
            SearchNewFlightsButton.Click();
        }


        private void EnterFlyingOutDay(string flyingOutDay)
        {
            SelectElement flyingOutDayList = new SelectElement(FlyingOutDay);
            flyingOutDayList.SelectByValue(flyingOutDay);
        }

        private void EnterFlyingOutMonthYear(string flyingOutMonthYear)
        {
            SelectElement flyingOutMonthYearList = new SelectElement(FlyingOutMonthYear);
            flyingOutMonthYearList.SelectByValue(flyingOutMonthYear);
        }


    }
}
