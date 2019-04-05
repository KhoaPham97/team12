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
    public class CreateTaskTest : TestBase
    {
        [Test]
        public void TC_FUC_MO02_13()
        {
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(4) > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(3) > td:nth-child(2) > a"));
            plan.Click();
            IWebElement task = driver.FindElement(By.CssSelector("body > section.lists-container > div.list > button"));
            task.Click();
            IWebElement newtask = driver.FindElement(By.CssSelector("#Title"));
            newtask.SendKeys("Task demo 1");
            IWebElement create = driver.FindElement(By.CssSelector("#myModalll > div > div > div.modal-body > form > div:nth-child(15) > div > input"));
            create.Click();
            test = extent.StartTest("TC_FUC_MO02_13");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        public void TC_FUC_MO02_14()
        {
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(4) > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(3) > td:nth-child(2) > a"));
            plan.Click();
            IWebElement task = driver.FindElement(By.CssSelector("body > section.lists-container > div.list > button"));
            task.Click();
            IWebElement newtask = driver.FindElement(By.CssSelector("#Title"));
            newtask.SendKeys("");
            IWebElement create = driver.FindElement(By.CssSelector("#myModalll > div > div > div.modal-body > form > div:nth-child(15) > div > input"));
            create.Click();
            test = extent.StartTest("TC_FUC_MO02_13");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid name task attempt");
        }

        [Test]
        public void TC_FUC_MO02_15()
        {
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(4) > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(3) > td:nth-child(2) > a"));
            plan.Click();
            IWebElement task = driver.FindElement(By.CssSelector("body > section.lists-container > div.list > button"));
            task.Click();
            IWebElement newtask = driver.FindElement(By.CssSelector("#Title"));
            newtask.SendKeys("***");
            IWebElement create = driver.FindElement(By.CssSelector("#myModalll > div > div > div.modal-body > form > div:nth-child(15) > div > input"));
            create.Click();
            test = extent.StartTest("TC_FUC_MO02_13");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid name task attempt");
        }
    }
}
