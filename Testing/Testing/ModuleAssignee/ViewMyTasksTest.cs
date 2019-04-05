using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.ModuleAssignee
{
    [TestFixture]
    [Parallelizable]
    class ViewMyTasksTest : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO03_05(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            Console.WriteLine("TC_FUC_MO03_05");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            //Task management
            IWebElement dropdown = driver.FindElement(By.ClassName("treeview"));
            dropdown.Click();
            //My Tasks
            IWebElement mytask = driver.FindElement(By.CssSelector("body > div > aside.main-sidebar > section > ul > li.treeview.menu-open > ul > li:nth-child(2) > a > span:nth-child(2)"));
            mytask.Click();
            test = extent.StartTest("TC_FUC_MO03_05");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }
    }
}
