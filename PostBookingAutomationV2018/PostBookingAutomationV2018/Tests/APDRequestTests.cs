using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium;
using PostBookingV2018.Pages;
using Selenium.Pages;

namespace PostBookingAutomationV2018.Tests
{
    [TestFixture]
    public class APDRequestTests

      
    {
        [Test]
        public void TestMethod1()
        {
            var apdRefundPage = new ApdRefundPage(new ChromeDriver());
            apdRefundPage.SubmitForm();

        }
    }
}
