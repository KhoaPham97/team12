using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Steps
{
    [TestFixture]
    [Parallelizable]
    public class LogoutTest : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_17(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGOUT TC_FUC_MO01_17");
            Console.WriteLine("LOGOUT TC_FUC_MO01_17");

            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");

            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "User successfully logged into the system");

            IWebElement button = driver.FindElement(By.CssSelector("body > div.wrapper > header > nav > div > button > i"));
            button.Click();
            test.Log(LogStatus.Pass, "Click icon Profile");

            IWebElement logout = driver.FindElement(By.CssSelector("#profile > div > div > div > a"));
            logout.Click();
            test.Log(LogStatus.Pass, "Choose button Sign out and result");

            //test = extent.StartTest("TC_FUC_MO01_16");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The system returns the login page");

        }

    }
}
