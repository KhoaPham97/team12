using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        public void TC_FUC_MO01_01()
        {
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
        }

        [Test]
        public void TC_FUC_MO01_02()
        {
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

           /* IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is not a valid e-mail address"));
            Assert.AreEqual(alert.Text, "The Email field is not a valid e-mail address");*/
        }

        [Test]
        public void TC_FUC_MO01_03()
        {
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

           /* IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken"));
            Assert.AreEqual(alert.Text, "Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken");*/
        }

        [Test]
        public void TC_FUC_MO01_04()
        {
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

            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is not a valid e-mail address"));
            Assert.AreEqual(alert.Text, "The Email field is not a valid e-mail address");*/
        }

        [Test]
        public void TC_FUC_MO01_05()
        {
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

            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The password and confirmation password do not match"));
            Assert.AreEqual(alert.Text, "The password and confirmation password do not match");*/
        }

        [Test]
        public void TC_FUC_MO01_06()
        {
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_06");
            IWebElement pass = driver.FindElement(By.CssSelector("#Password"));
            pass.SendKeys("1234567890");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();

            /*IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is required"));
            Assert.AreEqual(alert.Text, "The Email field is required");*/
        }

        [Test]
        public void TC_FUC_MO01_07()
        {
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_07");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            IWebElement pass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            pass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();

           /* IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Password field is required. The password and confirmation password do not match"));
            Assert.AreEqual(alert.Text, "The Password field is required. The password and confirmation password do not match");*/
        }

        [Test]
        public void TC_FUC_MO01_08()
        {
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_08");
            IWebElement email = driver.FindElement(By.CssSelector("#Email"));
            email.SendKeys("trangnguyen113@gmail.com");
            IWebElement confirmpass = driver.FindElement(By.CssSelector("#ConfirmPassword"));
            confirmpass.SendKeys("1234567890");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();

           /* IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The password and confirmation password do not match"));
            Assert.AreEqual(alert.Text, "The password and confirmation password do not match");*/
        }

        [Test]
        public void TC_FUC_MO01_09()
        {
            IWebElement register = driver.FindElement(By.CssSelector("#loginForm > form > div.text-center.w-full.p-t-23 > a"));
            register.Click();
            Console.WriteLine("TC_FUC_MO01_09");
            IWebElement regis = driver.FindElement(By.CssSelector("body > form > div:nth-child(8) > div > input"));
            regis.Click();

           /* IAlert alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Match("The Email field is required. The Password field is required"));
            Assert.AreEqual(alert.Text, "The Email field is required. The Password field is required");*/
        }
    }
}
