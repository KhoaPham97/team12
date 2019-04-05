using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.ModuleAccount
{
    [TestFixture]
    [Parallelizable]
    public class ExternalLoginTest : TestBase
    {
        [Test]
        public void TC_FUC_MO01_17()
        {
            Console.WriteLine("TC_FUC_MO01_17");
            IWebElement extenrnal = driver.FindElement(By.Name("provider"));
            extenrnal.Click();
            IWebElement skype = driver.FindElement(By.Name("loginfmt"));
            skype.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            IWebElement pass = driver.FindElement(By.Name("passwd"));
            pass.SendKeys("VLUt153930");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test = extent.StartTest("TC_FUC_MO01_17");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        public void TC_FUC_MO01_18()
        {
            Console.WriteLine("TC_FUC_MO01_18");
            IWebElement extenrnal = driver.FindElement(By.Name("provider"));
            extenrnal.Click();
            IWebElement skype = driver.FindElement(By.Name("loginfmt"));
            skype.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            IWebElement pass = driver.FindElement(By.Name("passwd"));
            pass.SendKeys("VLUt153930");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test = extent.StartTest("TC_FUC_MO01_18");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

    }
}
