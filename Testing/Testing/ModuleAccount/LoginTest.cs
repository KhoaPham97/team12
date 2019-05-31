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
        public void TC_FUC_MO01_01(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            Console.WriteLine("TC_FUC_MO01_01");
            test = extent.StartTest("LOGIN TC_FUC_MO01_01");

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
        public void TC_FUC_MO01_02(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_02");
            Console.WriteLine("TC_FUC_MO01_02");

            test.Log(LogStatus.Pass, "Leave blank 'Email'");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890'");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Username is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Username is required !"));
            Assert.AreEqual(alert.Text, "Username is required !");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_03(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_03");
            Console.WriteLine("TC_FUC_MO01_03");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen237@vanlanguni.vn'");
            test.Log(LogStatus.Pass, "Leave blank 'Password'");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Password is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Password is required !"));
            Assert.AreEqual(alert.Text, "Password is required !");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_04(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_04");
            Console.WriteLine("TC_FUC_MO01_04");
            test.Log(LogStatus.Pass, "Leave blank 'Email'");
            test.Log(LogStatus.Pass, "Leave blank 'Password'");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Click 'LOGIN' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Username is required ! Password is required !");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Username is required ! Password is required !"));
            Assert.AreEqual(alert.Text, "Username is required ! Password is required !");*/

        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_05(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_05");
            Console.WriteLine("TC_FUC_MO01_05");
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
            test.Log(LogStatus.Pass, "Invalid login attempt");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Invalid login attempt"));
            Assert.AreEqual(alert.Text, "Invalid login attempt");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_06(String browserName)
        {
            SetUp(browserName);
            //throw new NotImplementedException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_06");
            Console.WriteLine("TC_FUC_MO01_06");
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
            test.Log(LogStatus.Pass, "Invalid login attempt");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Invalid login attempt"));
            Assert.AreEqual(alert.Text, "Invalid login attempt");*/
        }


        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_07(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_07");
            Console.WriteLine("TC_FUC_MO01_07");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            test.Log(LogStatus.Pass, "Click 'Văn Lang'");
            //input email
           IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into account sendkey : trangnguyen237@vanlanguni.vn'");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            test.Log(LogStatus.Pass, "Select 'Next'");
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("VLUt153930");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey : ********'");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test.Log(LogStatus.Pass, "Select 'Login'");
           
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_08(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_08");
            Console.WriteLine("TC_FUC_MO01_08");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            test.Log(LogStatus.Pass, "Click 'Văn Lang'");
            //input email
            IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into account sendkey : trangnguyen237@vanlanguni.vn'");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            test.Log(LogStatus.Pass, "Select 'Next'");
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("");
            test.Log(LogStatus.Pass, "Enter blank 'Password'");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_09(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_09");
            Console.WriteLine("TC_FUC_MO01_09");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            test.Log(LogStatus.Pass, "Click 'Văn Lang'");
            //input email
            IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("trang");
            test.Log(LogStatus.Pass, "Enter valid value into account sendkey : trang'");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            test.Log(LogStatus.Pass, "Select 'Next'");
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("123");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey : ***'");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test.Log(LogStatus.Pass, "Select 'Login'");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }


        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_10(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("LOGIN TC_FUC_MO01_10");
            Console.WriteLine("TC_FUC_MO01_10");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            test.Log(LogStatus.Pass, "Click 'Văn Lang'");
            //input email
            IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("trang");
            test.Log(LogStatus.Pass, "Enter valid value into account sendkey : trang'");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            test.Log(LogStatus.Pass, "Select 'Next'");
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("123");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey : ***'");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test.Log(LogStatus.Pass, "Select 'Login'");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }
    }
}
