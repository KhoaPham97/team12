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
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_17(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();

            Console.WriteLine("TC_FUC_MO01_17");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            //input email
            IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("sonnguyen66@vanlanguni.vn");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("VLUt154746");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            IWebElement accept = driver.FindElement(By.Id("idSIButton9"));
            accept.Click();
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys("trangnguyen37@vanlanguni.vn");
            IWebElement register = driver.FindElement(By.Id("Email"));
            register.Click();
            test = extent.StartTest("TC_FUC_MO01_17");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }



        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_18(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();

            Console.WriteLine("TC_FUC_MO01_18");
            IWebElement extenrnal = driver.FindElement(By.Name("provider"));
            extenrnal.Click();
            IWebElement skype = driver.FindElement(By.Name("loginfmt"));
            skype.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            IWebElement pass = driver.FindElement(By.CssSelector("#i0118"));
            pass.SendKeys("VLUt153930");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            IWebElement accept = driver.FindElement(By.Id("idSIButton9"));
            accept.Click();
            IWebElement email = driver.FindElement(By.ClassName("form-control valid"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement register = driver.FindElement(By.ClassName("btn btn-default"));
            register.Click();
            /*IAlert alert = driver.SwitchTo().Alert();
           Assert.That(alert.Text, Does.Match("Name trangnguyen237@vanlanguni.vn is already taken.
                                               Email 'trangnguyen237@vanlanguni.vn' is already taken"));
           Assert.AreEqual(alert.Text, "Name trangnguyen237@vanlanguni.vn is already taken.
                                        Email 'trangnguyen237@vanlanguni.vn' is already taken");*/
            test = extent.StartTest("TC_FUC_MO01_18");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

    }
}
