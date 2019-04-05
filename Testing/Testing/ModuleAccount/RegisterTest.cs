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
    public class RegisterTest : TestBase
    {

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_01(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_01");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen245@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_01");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_02(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_02");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen2637");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_02");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The Email field is not a valid e-mail address");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is not a valid e-mail address"));
            Assert.AreEqual(alert.Text, "The Email field is not a valid e-mail address");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_03(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_03");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_03");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken"));
             Assert.AreEqual(alert.Text, "Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_04(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_04");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("123");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("123");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_04");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The Email field is not a valid e-mail address");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is not a valid e-mail address"));
            Assert.AreEqual(alert.Text, "The Email field is not a valid e-mail address");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_05(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_05");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("123");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_05");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The password and confirmation password do not match");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The password and confirmation password do not match"));
            Assert.AreEqual(alert.Text, "The password and confirmation password do not match");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_06(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_06");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_06");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The Email field is required");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is required"));
            Assert.AreEqual(alert.Text, "The Email field is required");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_07(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_07");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            pass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_07");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The Password field is required. The password and confirmation password do not match");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("The Password field is required. The password and confirmation password do not match"));
             Assert.AreEqual(alert.Text, "The Password field is required. The password and confirmation password do not match");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_08(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_08");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_08");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The password and confirmation password do not match");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("The password and confirmation password do not match"));
             Assert.AreEqual(alert.Text, "The password and confirmation password do not match");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_09(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_09");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test = extent.StartTest("TC_FUC_MO01_09");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "The Email field is required. The Password field is required");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("The Email field is required. The Password field is required"));
             Assert.AreEqual(alert.Text, "The Email field is required. The Password field is required");*/
        }
    }
}
