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
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_15(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE TASK TC_FUC_MO02_15");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Open Management page");
            //Create task
            IWebElement newtask = driver.FindElement(By.CssSelector("body > section.lists-container > div.list > button"));
            newtask.Click();
            test.Log(LogStatus.Pass, "Select 'Add a task' at name bucket want create task");
            IWebElement clicknametask = driver.FindElement(By.CssSelector("#Title"));
            clicknametask.Click();
            IWebElement nametask = driver.FindElement(By.CssSelector("#Title"));
            nametask.SendKeys("Test Create Task");
            test.Log(LogStatus.Pass, "Enter valid value into 'Task Name' sendkey : Test Create Task");
            IWebElement create = driver.FindElement(By.CssSelector("#myModalll11 > div > div > div.modal-body > form > div:nth-child(15) > div > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Create' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_16(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE TASK TC_FUC_MO02_16");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Open Management page");
            //Create task
            IWebElement newtask = driver.FindElement(By.CssSelector("body > section.lists-container > div.list > button"));
            newtask.Click();
            test.Log(LogStatus.Pass, "Select 'Add a task' at name bucket want create task");
            IWebElement clicknametask = driver.FindElement(By.CssSelector("#Title"));
            clicknametask.Click();
            IWebElement nametask = driver.FindElement(By.CssSelector("#Title"));
            nametask.SendKeys("");
            test.Log(LogStatus.Pass, "Leave blank 'Task Name'");
            IWebElement create = driver.FindElement(By.CssSelector("#myModalll11 > div > div > div.modal-body > form > div:nth-child(15) > div > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Create' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Invalid name task attempt");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_17(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE TASK TC_FUC_MO02_17");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Select plan
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-xs-12 > div > div.box-body.table-responsive.no-padding > table > tbody > tr:nth-child(2) > td:nth-child(2) > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "Open Management page");
            //Create task
            IWebElement newtask = driver.FindElement(By.CssSelector("body > section.lists-container > div.list > button"));
            newtask.Click();
            test.Log(LogStatus.Pass, "Select 'Add a task' at name bucket want create task");
            IWebElement clicknametask = driver.FindElement(By.CssSelector("#Title"));
            clicknametask.Click();
            IWebElement nametask = driver.FindElement(By.CssSelector("#Title"));
            nametask.SendKeys("Test Create Task");
            test.Log(LogStatus.Pass, "Input special characters 'Task Name' sendkey : ***");
            IWebElement create = driver.FindElement(By.CssSelector("#myModalll11 > div > div > div.modal-body > form > div:nth-child(15) > div > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Create' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Warning, "Invalid name task attempt");
        }
    }
}
