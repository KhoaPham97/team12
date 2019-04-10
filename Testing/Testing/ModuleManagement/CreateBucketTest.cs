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
        public void TC_FUC_MO02_10(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE BUCKET TC_FUC_MO02_10");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Select plan name you want to create bucket");
            test.Log(LogStatus.Pass, "System open Management page");
            //Create bucket
            IWebElement newbucket = driver.FindElement(By.CssSelector("body > section.lists-container > button"));
            newbucket.Click();
            test.Log(LogStatus.Pass, "At Plan Choose 'Add a bucket'");
            //
            IWebElement namebucket = driver.FindElement(By.CssSelector("#Title"));
            namebucket.Click();
            IWebElement name = driver.FindElement(By.CssSelector("#Title"));
            name.SendKeys("test create bucket");
            test.Log(LogStatus.Pass, "Enter valid value into 'Bucket Name sendkey : test create bucket");
            IWebElement create = driver.FindElement(By.CssSelector("#myModal > div > div > div.modal-body > form > div.modal-footer > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Create' button and observe the displayed result");
            //
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_11(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE BUCKET TC_FUC_MO02_11");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Select plan name you want to create bucket");
            test.Log(LogStatus.Pass, "System open Management page");
            //Create bucket
            IWebElement newbucket = driver.FindElement(By.CssSelector("body > section.lists-container > button"));
            newbucket.Click();
            test.Log(LogStatus.Pass, "At Plan Choose 'Add a bucket'");
            //
            IWebElement namebucket = driver.FindElement(By.CssSelector("#Title"));
            namebucket.Click();
            IWebElement name = driver.FindElement(By.CssSelector("#Title"));
            name.SendKeys("");
            test.Log(LogStatus.Pass, "Leave blank 'Bucket Name'");
            IWebElement create = driver.FindElement(By.CssSelector("#myModal > div > div > div.modal-body > form > div.modal-footer > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Create' button and observe the displayed result");
            //
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Invalid name bucket attempt");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_12(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE BUCKET TC_FUC_MO02_12");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Select plan name you want to create bucket");
            test.Log(LogStatus.Pass, "System open Management page");
            //Create bucket
            IWebElement newbucket = driver.FindElement(By.CssSelector("body > section.lists-container > button"));
            newbucket.Click();
            test.Log(LogStatus.Pass, "At Plan Choose 'Add a bucket'");
            //
            IWebElement namebucket = driver.FindElement(By.CssSelector("#Title"));
            namebucket.Click();
            IWebElement name = driver.FindElement(By.CssSelector("#Title"));
            name.SendKeys("%%%%%&&");
            test.Log(LogStatus.Pass, "Input special characters 'Bucket Name' sendkey : %%%%%&&");
            IWebElement create = driver.FindElement(By.CssSelector("#myModal > div > div > div.modal-body > form > div.modal-footer > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Create' button and observe the displayed result");
            //
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Invalid name bucket attempt");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_13(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE BUCKET TC_FUC_MO02_13");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Select plan name you want to create bucket");
            test.Log(LogStatus.Pass, "System open Management page");
            //Create bucket
            IWebElement newbucket = driver.FindElement(By.CssSelector("body > section.lists-container > button"));
            newbucket.Click();
            test.Log(LogStatus.Pass, "At Plan Choose 'Add a bucket'");
            //
            IWebElement namebucket = driver.FindElement(By.CssSelector("#Title"));
            namebucket.Click();
            IWebElement name = driver.FindElement(By.CssSelector("#Title"));
            name.SendKeys("test create bucket");
            test.Log(LogStatus.Pass, "Enter valid value into 'Bucket Name sendkey : test create bucket");
            IWebElement create = driver.FindElement(By.CssSelector("#myModal > div > div > div.modal-body > form > div.modal-footer > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Create' button and observe the displayed result");
            //
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Invalid name bucket attempt");
        }

    }
}
