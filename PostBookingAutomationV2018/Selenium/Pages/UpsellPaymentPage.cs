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
    public class UpSellPaymentPage
    {
        private IWebDriver Driver { get; }


        public UpSellPaymentPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[name='nameOnCard']")] private IWebElement CardholderNameField;
        [FindsBy(How = How.CssSelector, Using = "select[name='cardType']")] private IWebElement TypeOfCardList;
        [FindsBy(How = How.CssSelector, Using = "input[name='numOfCard']")] private IWebElement CardNumberField;
        [FindsBy(How = How.CssSelector, Using = "input[name='securityCode']")] private IWebElement SecurityCodeField;
        [FindsBy(How = How.CssSelector, Using = "select[name='cardMonth']")] private IWebElement ExpiryMonthList;
        [FindsBy(How = How.CssSelector, Using = "select[name='cardYear']")] private IWebElement ExpiryYearList;
        [FindsBy(How = How.CssSelector, Using = "input[name='terms']")] private IWebElement TCsCheckBox;
        [FindsBy(How = How.CssSelector, Using = "input[name='memPassword']")] private IWebElement MemberAccountPassword;
        [FindsBy(How = How.CssSelector, Using = "input[name='btn_Back']")] private IWebElement CancelButton;
        [FindsBy(How = How.CssSelector, Using = "input[id='continueButton']")] private IWebElement PayNowButton;
     

        public void EnterCardDetailsName()
        {
            CardholderNameField.SendKeys("mr t");
            TypeOfCardList.Click();
            EnterCardType("9");
            CardNumberField.SendKeys("4111111111111111");
            SecurityCodeField.SendKeys("737");
            EnterMonthExpiry("08");
            EnterYearExpiry("2018");
            TCsCheckBox.Click();
            MemberAccountPassword.SendKeys("password123");
            PayNowButton.Click();
            var a = Driver.SwitchTo().Alert();
            a.Accept();
            //a.Dismiss();
        }

        private void EnterCardType(string cardType)
        {
            SelectElement cardTypeList = new SelectElement(TypeOfCardList);
            cardTypeList.SelectByValue(cardType);
        }
        private void EnterMonthExpiry(string month)
        {
            SelectElement monthExpiryList = new SelectElement(ExpiryMonthList);
            monthExpiryList.SelectByValue(month);
        }

        private void EnterYearExpiry(string year)
        {
            SelectElement yearExpiryList = new SelectElement(ExpiryYearList);
            yearExpiryList.SelectByValue(year);
        }
    }
}
