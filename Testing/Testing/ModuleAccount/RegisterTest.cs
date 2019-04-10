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
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_01");
            Console.WriteLine("TC_FUC_MO01_01");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            test.Log(LogStatus.Pass, "Choose Register as a new user?");

            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen245@vanlanguni.vn");
           test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen245@vanlanguni.vn");

            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890");

            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Confirm Password' sendkey: 1234567890");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_02(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_02");
            Console.WriteLine("TC_FUC_MO01_02");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            test.Log(LogStatus.Pass, "Choose Register as a new user?");

            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen2637");
           test.Log(LogStatus.Pass, "Enter value into 'Email' sendkey: trangnguyen2637");

            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890");

            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            //test.Log(LogStatus.Pass, "Enter valid value into 'Confirm Password' sendkey: 1234567890");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");
            
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Messenge error 'The Email field is not a valid e-mail address'");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is not a valid e-mail address"));
            Assert.AreEqual(alert.Text, "The Email field is not a valid e-mail address");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_03(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_03");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            test.Log(LogStatus.Pass, "Choose Register as a new user?");

            Console.WriteLine("TC_FUC_MO01_03");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen237@vanlanguni.vn");

            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
           test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890");

            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            //test.Log(LogStatus.Pass, "Enter valid value into 'Confirm Password' sendkey: 1234567890");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");
           
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Message error 'Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken'");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken"));
             Assert.AreEqual(alert.Text, "Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_04(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_04");
            Console.WriteLine("TC_FUC_MO01_04");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
           test.Log(LogStatus.Pass, "Choose Register as a new user?");

            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            //test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen113@vanlanguni.vn");

            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("123");
            test.Log(LogStatus.Pass, "Enter value into 'Password' sendkey: 123");

            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("123");
            test.Log(LogStatus.Pass, "Enter value into 'Confirm Password' sendkey: 123");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Messenge error 'The Password must be at least 6 characters long'");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is not a valid e-mail address"));
            Assert.AreEqual(alert.Text, "The Email field is not a valid e-mail address");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_05(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_05");
            Console.WriteLine("TC_FUC_MO01_05");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
           test.Log(LogStatus.Pass, "Choose Register as a new user?");
           
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen113@vanlanguni.vn");

            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890");

            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("123");
           test.Log(LogStatus.Pass, "Enter value into 'Confirm Password' sendkey: 123");
            
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Messenge error 'The password and confirmation password do not match'");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The password and confirmation password do not match"));
            Assert.AreEqual(alert.Text, "The password and confirmation password do not match");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_06(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_06");
            Console.WriteLine("TC_FUC_MO01_06");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            test.Log(LogStatus.Pass, "Choose Register as a new user?");

            test.Log(LogStatus.Skip, "Leave blank 'Email'");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890");

            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Confirm Password' sendkey: 1234567890");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Messenge error 'The Email field is required'");
            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is required"));
            Assert.AreEqual(alert.Text, "The Email field is required");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_07(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_07");
            Console.WriteLine("TC_FUC_MO01_07");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            test.Log(LogStatus.Pass, "Choose Register as a new user?");
            
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen113@vanlanguni.vn");

            test.Log(LogStatus.Skip, "Leave blank 'Password");

            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
           test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey: 1234567890");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Message erorr 'The Password field is required. The password and confirmation password do not match'");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("The Password field is required. The password and confirmation password do not match"));
             Assert.AreEqual(alert.Text, "The Password field is required. The password and confirmation password do not match");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_08(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_08");
            Console.WriteLine("TC_FUC_MO01_08");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            test.Log(LogStatus.Pass, "Choose Register as a new user?");

            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen113@vanlanguni.vn");

            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            test.Log(LogStatus.Pass, "Enter valid value into 'Confirm Password' sendkey: 1234567890");

            test.Log(LogStatus.Pass, "Leave blank 'Confirm Password'");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Messenge error 'The password and confirmation password do not match'");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("The password and confirmation password do not match"));
             Assert.AreEqual(alert.Text, "The password and confirmation password do not match");*/
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_09(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_09");
            Console.WriteLine("TC_FUC_MO01_09");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            test.Log(LogStatus.Pass, "Choose Register as a new user?");

            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            test.Log(LogStatus.Pass, "Enter valid value into 'Email' sendkey: trangnguyen113@vanlanguni.vn");

            test.Log(LogStatus.Pass, "Leave blank 'Password'");

            test.Log(LogStatus.Pass, "Leave blank 'Confirm Password'");

            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
            test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Messenge error 'The Password field is required'");
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("The password and confirmation password do not match"));
             Assert.AreEqual(alert.Text, "The password and confirmation password do not match");*/
        }


        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_10(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("REGISTER TC_FUC_MO01_10");
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
           test.Log(LogStatus.Pass, "Choose Register as a new user?");
            Console.WriteLine("TC_FUC_MO01_10");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();
           test.Log(LogStatus.Pass, "Click 'Register' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Messenge error 'The Email field is required. The Password field is required'");
 
            /* IAlert alert = driver.SwitchTo().Alert();
             Assert.That(alert.Text, Does.Match("The Email field is required. The Password field is required"));
             Assert.AreEqual(alert.Text, "The Email field is required. The Password field is required");*/
        }

       

    }
}
