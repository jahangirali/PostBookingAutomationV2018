using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using PostBookingV2018.Pages;

namespace PostBookingV2018.Tests
{
    public class LoginPageTests: TestBase
    {
        public class LoginTests
        {
            [Test]
            public void Login()
            {
                var loginPage = new LoginPage(driver);

                loginPage.LoggedIn();
            }
        }
    }
}
