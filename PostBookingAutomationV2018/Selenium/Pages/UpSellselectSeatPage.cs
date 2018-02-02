using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class UpSellSelectSeatPage
    {
        private IWebDriver Driver { get; }

        public UpSellSelectSeatPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "span[class='saveOnline']")] private IWebElement AlwaysCheaperOnlineLabel;

        public string AlwaysCheaperOnlineText()
        {
            //labelText = AlwaysCheaperOnlineLabel.Text;
            //Console.WriteLine(labelText);
            //return labelText;
            
            return AlwaysCheaperOnlineLabel.Text.Trim();
            
        }
    }



}
