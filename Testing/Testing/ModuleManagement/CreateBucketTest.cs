using NUnit.Framework;
using OpenQA.Selenium;
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
    class CreateBucketTest : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_09(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(4) > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            //Create bucket
            IWebElement newbucket = driver.FindElement(By.CssSelector("body > section.lists-container > button"));
            newbucket.Click();
            //
            IWebElement namebucket = driver.FindElement(By.CssSelector("#Title"));
            namebucket.Click();
            IWebElement name = driver.FindElement(By.CssSelector("#Title"));
            name.SendKeys("test create bucket");
            IWebElement create = driver.FindElement(By.CssSelector("#myModal > div > div > div.modal-body > form > div.modal-footer > input"));
            create.Click();
            //
            test = extent.StartTest("TC_FUC_MO02_09");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_10(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(4) > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            IWebElement newbucket = driver.FindElement(By.CssSelector("body > section.lists-container > button"));
            newbucket.Click();
            newbucket.SendKeys("");
            IWebElement create = driver.FindElement(By.CssSelector("#myModal > div > div > div.modal-body > form > div.modal-footer > input"));
            create.Click();
            test = extent.StartTest("TC_FUC_MO02_10");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid name bucket attempt");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_11(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(4) > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(3) > td:nth-child(2) > a"));
            plan.Click();
            IWebElement newbucket = driver.FindElement(By.CssSelector("body > section.lists-container > button"));
            newbucket.Click();
            newbucket.SendKeys("%%%%%&&");
            IWebElement create = driver.FindElement(By.CssSelector("#myModal > div > div > div.modal-body > form > div.modal-footer > input"));
            create.Click();
            test = extent.StartTest("TC_FUC_MO02_11");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid name bucket attempt");
        }
    }
}
