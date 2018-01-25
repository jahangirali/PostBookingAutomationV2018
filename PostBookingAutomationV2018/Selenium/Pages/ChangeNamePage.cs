using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Pages
{
    public class ChangeNamePage
    {
        private IWebDriver Driver { get; }
        //private static readonly By PageSelector = By.CssSelector("a[id='ContactDetailsLinkBreadcrumb']");

        public ChangeNamePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "div[id='ContactDetailsLinkBreadcrumb']")] private IWebElement TitleField;
        [FindsBy(How = How.CssSelector, Using = "input[name='firstName1']")] private IWebElement FirstNameField;
        [FindsBy(How = How.CssSelector, Using = "input[name='lastName1']")] private IWebElement LastNameField;
        [FindsBy(How = How.CssSelector, Using = "a[id='ContactDetailsLinkBreadcrumb']")] private IWebElement BackButton;
        [FindsBy(How = How.CssSelector, Using = "input[id='continueButton']")] private IWebElement ContinueButton;


        public void ChangeName()
        {
            EnterFirstNameField();
            EnterLastNameField();
            ClickContinue();
            Thread.Sleep(10);
            ClickContinue();

        }
        
        private void EnterFirstNameField()
        {
            FirstNameField.Clear();
            FirstNameField.SendKeys("Jeff");

        }

        private void EnterLastNameField()
        {
            LastNameField.Clear();
            LastNameField.SendKeys("Jefferson");
        }

        private void ClickContinue()
        {
            ContinueButton.Click();
        }
    }
}
