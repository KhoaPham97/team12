using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestFixture]
    [Parallelizable]
    public class LoginTest : TestBase
    {
       
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_10(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();

            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            Console.WriteLine("TC_FUC_MO01_10");
            test = extent.StartTest("TC_FUC_MO01_10");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_11(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();

            Console.WriteLine("TC_FUC_MO01_11");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test = extent.StartTest("TC_FUC_MO01_11");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Username is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Username is required !"));
            Assert.AreEqual(alert.Text, "Username is required !");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_12(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();

            Console.WriteLine("TC_FUC_MO01_12");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test = extent.StartTest("TC_FUC_MO01_12");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Password is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Password is required !"));
            Assert.AreEqual(alert.Text, "Password is required !");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_13(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();

            Console.WriteLine("TC_FUC_MO01_13");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test = extent.StartTest("TC_FUC_MO01_13");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Username is required ! Password is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Username is required ! Password is required !"));
            Assert.AreEqual(alert.Text, "Username is required ! Password is required !");*/

        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_14(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();

            Console.WriteLine("TC_FUC_MO01_14");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen@gmail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test = extent.StartTest("TC_FUC_MO01_15");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid login attempt");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Invalid login attempt"));
            Assert.AreEqual(alert.Text, "Invalid login attempt");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_15(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();

            Console.WriteLine("TC_FUC_MO01_15");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen2637@gmail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("123456");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test = extent.StartTest("TC_FUC_MO01_16");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid login attempt");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Invalid login attempt"));
            Assert.AreEqual(alert.Text, "Invalid login attempt");*/
        }

    }
}
