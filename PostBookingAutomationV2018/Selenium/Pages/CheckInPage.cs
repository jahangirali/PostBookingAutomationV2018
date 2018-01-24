using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class CheckInPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("a[id='YourBookingsLinkBreadcrumb']");

        public CheckInPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[id='gotoOldMyEasyjetButton']")] private IWebElement ManageBookingsButton;


        public void ClickManageBookingsButton()
        {
            ManageBookingsButton.Click();
        }
    }
}
