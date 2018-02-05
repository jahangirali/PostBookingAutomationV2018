using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class UpSellSeatPanelSelectorPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("a[id='ContactDetailsLinkBreadcrumb']");
    }

    public ViewBookingsPage(IWebDriver driver)
    {
        Driver = driver;
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.Id, Using = "YourBookingsLinkBreadcrumb")] private IWebElement AllBookings;
}
