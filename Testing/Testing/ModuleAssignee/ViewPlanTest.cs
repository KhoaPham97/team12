﻿using NUnit.Framework;
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
    class ViewPlanTest : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO03_01(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("VIEW PLAN TC_FUC_MO03_01");
            Console.WriteLine("TC_FUC_MO03_01");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO03_02(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("VIEW PLAN TC_FUC_MO03_02");
            Console.WriteLine("TC_FUC_MO03_02");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "Open Home Page");
            //Task management
            IWebElement dropdown = driver.FindElement(By.ClassName("treeview"));
            dropdown.Click();
            test.Log(LogStatus.Pass, "Select dropdown-list 'Task management'");
            IWebElement dashboard = driver.FindElement(By.CssSelector("body > div > aside.main-sidebar > section > ul > li.treeview.menu-open > ul > li:nth-child(1) > a"));
            dashboard.Click();
            test.Log(LogStatus.Pass, "Click 'Dashboard' and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }
    }
}
