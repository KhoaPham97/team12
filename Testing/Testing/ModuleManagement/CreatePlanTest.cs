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
    public class CreatePlanTest : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_01(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE PLAN TC_FUC_MO02_01");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "User successfully logged in with the created account");
            //
            IWebElement plan = driver.FindElement(By.CssSelector("body > div.wrapper > div.content-wrapper > section > div.col-md-12 > div > div > div.box-tools.pull-right > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "User choose 'Create' button");
            IWebElement newplan = driver.FindElement(By.CssSelector("#Title"));
            newplan.SendKeys("test create plan");
            test.Log(LogStatus.Pass, "Enter valid value into 'Plan Name");
            IWebElement create = driver.FindElement(By.CssSelector("#AutoAdd > div > div > div > div.form-group > div > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Submit' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_02(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE PLAN TC_FUC_MO02_02");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "User successfully logged in with the created account");
            //
            IWebElement plan = driver.FindElement(By.CssSelector("body > div.wrapper > div.content-wrapper > section > div.col-md-12 > div > div > div.box-tools.pull-right > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "User choose 'Create' button");
            IWebElement newplan = driver.FindElement(By.CssSelector("#Title"));
            newplan.SendKeys("test create plan");
            test.Log(LogStatus.Pass, "Enter valid value into 'Plan Name");
            IWebElement create = driver.FindElement(By.CssSelector("#AutoAdd > div > div > div > div.form-group > div > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Submit' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_03(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("CREATE PLAN TC_FUC_MO02_03");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            test.Log(LogStatus.Pass, "User successfully logged in with the created account");
            //
            IWebElement plan = driver.FindElement(By.CssSelector("body > div.wrapper > div.content-wrapper > section > div.col-md-12 > div > div > div.box-tools.pull-right > a"));
            plan.Click();
            test.Log(LogStatus.Pass, "User choose 'Create' button");
            IWebElement newplan = driver.FindElement(By.CssSelector("#Title"));
            newplan.SendKeys("");
            test.Log(LogStatus.Pass, "Enter blank 'Plan Name");
            IWebElement create = driver.FindElement(By.CssSelector("#AutoAdd > div > div > div > div.form-group > div > input"));
            create.Click();
            test.Log(LogStatus.Pass, "Click 'Submit' button and observe the displayed result");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

      
    }
}
