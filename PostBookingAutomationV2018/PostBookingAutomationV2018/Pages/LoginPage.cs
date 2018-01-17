using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace PostBookingAutomationV2018.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.CssSelector("div[id=LogOnPanel']");

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;

        }


    }
}
