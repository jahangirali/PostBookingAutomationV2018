using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class ChangeFlightOptionsPage
    {
        private IWebDriver Driver { get; }


        public ChangeFlightOptionsPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[name='segment1']")] private IWebElement AvailableFlight;
        [FindsBy(How = How.CssSelector, Using = "input[name='btn_Back']")] private IWebElement BackButton;
        [FindsBy(How = How.CssSelector, Using = "input[id='continueButton']")] private IWebElement ContinueButton;

        public void SelectAvailableFlight()
        {
            AvailableFlight.Click();
            ContinueButton.Click();
            ContinueButton.Click();
        }

        private void ClickContinueButton()
        {
            ContinueButton.Click();
        }
    }
}
