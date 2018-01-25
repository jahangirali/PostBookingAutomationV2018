using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class UpsellPaymentPage
    {
        private IWebDriver Driver { get; }


        public UpsellPaymentPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "div[id='ContactDetailsLinkBreadcrumb']")]
        private IWebElement TitleField;




    }
}
