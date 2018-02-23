﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class ApdRefundRequestPage
    {
        private IWebDriver Driver { get; }
        private static readonly By PageSelector = By.Id("BookingDetails_BookingReference");

        public ApdRefundRequestPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "BookingDetails_BookingReference")] private IWebElement BookingReferenceField;
        [FindsBy(How = How.Id, Using = "BookingDetails_BookersFirstName")] private IWebElement BookersFirstNameField;
        [FindsBy(How = How.Id, Using = "BookingDetails_Surname")] private IWebElement BookersSurnameField;
        [FindsBy(How = How.Id, Using = "isTheBooker")] private IWebElement IsTheBookerCheckbox;
        [FindsBy(How = How.Id, Using = "ClaimantDetails_FirstName")] private IWebElement ClaimantFirstNameField;
        [FindsBy(How = How.Id, Using = "ClaimantDetails_Surname")] private IWebElement ClaimantSurnameField;
        [FindsBy(How = How.Id, Using = "ClaimantDetails_EmailAddress")] private IWebElement ClaimantEmailAddressField;
        [FindsBy(How = How.Id, Using = "ClaimantDetails_TelephoneCountryCode")] private IWebElement ClaimantTelephoneCountryCodeField;
        [FindsBy(How = How.Id, Using = "ClaimantDetails_TelephoneNumber")] private IWebElement ClaimantTelephoneNumberField;
        [FindsBy(How = How.Id, Using = "Flight_FlightNumber")] private IWebElement FlightNumberField;

        [FindsBy(How = How.CssSelector, Using = "span[id='allPassengers']")] private IWebElement AllPassengersRadioButton;
        [FindsBy(How = How.CssSelector, Using = "span[id='allPassengers']")] private IWebElement AcceptTermsCheckbox;

        [FindsBy(How = How.Id, Using = "Sumbit")] private IWebElement SubmitButton;



        public void SubmitForm()
        {
            ClickSubmitButton();
        }



        private void ClickSubmitButton()
        {
            SubmitButton.Click();
        }
    }
}
