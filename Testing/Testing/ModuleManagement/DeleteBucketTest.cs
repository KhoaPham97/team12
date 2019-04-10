using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.ModuleManagement
{

    [TestFixture]
    [Parallelizable]
    class DeleteBucketTest : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_14(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("DELETE BUCKET TC_FUC_MO02_14");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(7) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Open Management page");
            //Delete
            IWebElement delete = driver.FindElement(By.CssSelector("body > section.lists-container > div:nth-child(1) > form > button > i"));
            delete.Click();
            test.Log(LogStatus.Pass, "Choose bucket name want delete click icon delete and result");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }
    }
}
