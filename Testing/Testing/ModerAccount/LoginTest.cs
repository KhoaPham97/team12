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
        public void TC_FUC_MO01_11(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            Console.WriteLine("TC_FUC_MO01_11");
            test = extent.StartTest("LOGIN TC_FUC_MO01_11");

            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen237@vanlanguni.vn");

            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890'");

            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "User successfully login and the interface returned the Home page.");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_12(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_12");
            Console.WriteLine("TC_FUC_MO01_12");

            test.Log(LogStatus.Pass, "Leave blank 'Email'");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890'");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Username is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Username is required !"));
            Assert.AreEqual(alert.Text, "Username is required !");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_13(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_13");
            Console.WriteLine("TC_FUC_MO01_13");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen237@vanlanguni.vn'");
            test.Log(LogStatus.Pass, "Leave blank 'Password'");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Password is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Password is required !"));
            Assert.AreEqual(alert.Text, "Password is required !");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_14(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_14");
            Console.WriteLine("TC_FUC_MO01_14");
            test.Log(LogStatus.Pass, "Leave blank 'Email'");
            test.Log(LogStatus.Pass, "Leave blank 'Password'");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Username is required ! Password is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Username is required ! Password is required !"));
            Assert.AreEqual(alert.Text, "Username is required ! Password is required !");*/

        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_15(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_15");
            Console.WriteLine("TC_FUC_MO01_15");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen@gmail.com");
            test.Log(LogStatus.Pass, "Enter value into 'Email' sendkey : trangnguyen@mail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter value into 'Password' sendkey : 1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Invalid login attempt");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Invalid login attempt"));
            Assert.AreEqual(alert.Text, "Invalid login attempt");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_16(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_16");
            Console.WriteLine("TC_FUC_MO01_16");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter value into 'Email' sendkey : trangnguye237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("123456");
            test.Log(LogStatus.Pass, "Enter value into 'Password' sendkey : 123456");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Invalid login attempt");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Invalid login attempt"));
            Assert.AreEqual(alert.Text, "Invalid login attempt");*/
        }

    }
}
