using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PostBookingAutomationV2018.Pages
{
    public class AccountDetailsPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("a[id='ContactDetailsLinkBreadcrumb']");

        public AccountDetailsPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "a[id='ContactDetailsLinkBreadcrumb']")]private IWebElement YourAccountDetailsLink;


        public void ClickAccountDetails()
        {
            YourAccountDetailsLink.Click();
        }

    }
}
