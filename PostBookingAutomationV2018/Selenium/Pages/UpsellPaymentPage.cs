﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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
        [FindsBy(How = How.CssSelector, Using = "input[name='nameOnCard']")] private IWebElement ExpiryMonthList;
        [FindsBy(How = How.CssSelector, Using = "input[name='nameOnCard']")] private IWebElement ExpiryYearList;
        [FindsBy(How = How.CssSelector, Using = "input[name='terms']")] private IWebElement TCsCheckBox;
        [FindsBy(How = How.CssSelector, Using = "input[name='memPassword']")] private IWebElement MemberAccountPassword;
        [FindsBy(How = How.CssSelector, Using = "input[name='btn_Back']")] private IWebElement CancelButton;
        [FindsBy(How = How.CssSelector, Using = "input[id='continueButton']")] private IWebElement PayNowButton;
     

        public void EnterCardDetailsName()
        {
            CardholderNameField.SendKeys("mr t");
            TypeOfCardList.Click();
            TypeOfCardList.SendKeys(Keys.ArrowDown);
            CardNumberField.SendKeys("4111111111111111");
            SecurityCodeField.SendKeys("737");
            TCsCheckBox.Click();
            MemberAccountPassword.SendKeys("password123");
            PayNowButton.Click();
            Driver.SwitchTo().ActiveElement().Click();


        }
    }
}