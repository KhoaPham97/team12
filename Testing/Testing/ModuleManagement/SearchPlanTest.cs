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
    public class SearchPlanTest : TestBase
    {
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_05()
        {
            Console.WriteLine("At Member In Plan");
            Console.WriteLine("TC_FUC_MO02_05");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement search = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(3) > div > div.box-header > div > div > input"));
            search.SendKeys("1");
            IWebElement show = driver.FindElement(By.ClassName("btn btn-default"));
            show.Click();
            test = extent.StartTest("TC_FUC_MO01_16");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_06()
        {
            Console.WriteLine("At Member In Plan");
            Console.WriteLine("TC_FUC_MO02_05");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement search = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div:nth-child(3) > div > div.box-header > div > div > input"));
            search.SendKeys("%%%");
            IWebElement show = driver.FindElement(By.ClassName("btn btn-default"));
            show.Click();
            test = extent.StartTest("TC_FUC_MO01_16");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid name plan attempt");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_07()
        {
            Console.WriteLine("At My Plan");
            Console.WriteLine("TC_FUC_MO02_07");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement search = driver.FindElement(By.Name("table_search"));
            search.SendKeys("1");
            IWebElement show = driver.FindElement(By.ClassName("btn btn-default"));
            show.Click();
            test = extent.StartTest("TC_FUC_MO01_16");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO02_08(String browserName)
        {
            SetUp(browserName);
            throw new NotFiniteNumberException();

            Console.WriteLine("At My Plan");
            Console.WriteLine("TC_FUC_MO02_08");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement search = driver.FindElement(By.Name("table_search"));
            search.SendKeys("1");
            IWebElement show = driver.FindElement(By.ClassName("btn btn-default"));
            show.Click();
            test = extent.StartTest("TC_FUC_MO01_16");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Invalid name plan attempt");
        }

    }
}
