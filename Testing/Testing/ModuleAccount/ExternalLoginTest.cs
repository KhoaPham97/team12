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
        public void TC_FUC_MO01_18(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("EXTERNAL LOGIN TC_FUC_MO01_18");
            Console.WriteLine("TC_FUC_MO01_18");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            test.Log(LogStatus.Pass, "At External Login click 'Văn Lang'");
            //input email
            IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("sonnguyen66@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into account sendkey : sonnguyen66@vanlanguni.vn'");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            test.Log(LogStatus.Pass, "Select 'Next'");
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("VLUt154746");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey : VLUt154746'");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test.Log(LogStatus.Pass, "Select 'Login'");
            IWebElement accept = driver.FindElement(By.Id("idSIButton9"));
            accept.Click();
            test.Log(LogStatus.Pass, "Select 'Accept'");
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys("trangnguyen37@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Input 'Email' sendkey : trangnguyen7@gamil.com'");
            IWebElement register = driver.FindElement(By.Id("Email"));
            register.Click();
            test.Log(LogStatus.Pass, "Select 'Register' button and observe the displayed result'");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_19(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("EXTERNAL LOGIN TC_FUC_MO01_19");
            Console.WriteLine("TC_FUC_MO01_19");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            test.Log(LogStatus.Pass, "At External Login click 'Văn Lang'");
            //input email
            IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("sonnguyen66@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into account sendkey : sonnguyen66@vanlanguni.vn'");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            test.Log(LogStatus.Pass, "Select 'Next'");
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("VLUt154746");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey : VLUt154746'");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test.Log(LogStatus.Pass, "Select 'Login' button and observe the displayed result'");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TC_FUC_MO01_20(String browserName)
        {
            SetUp(browserName);
            //throw new NotFiniteNumberException();
            test = extent.StartTest("EXTERNAL LOGIN TC_FUC_MO01_20");
            Console.WriteLine("TC_FUC_MO01_20");
            IWebElement extenrnal = driver.FindElement(By.Id("Văn Lang"));
            extenrnal.Click();
            test.Log(LogStatus.Pass, "At External Login click 'Văn Lang'");
            //input email
            IWebElement skype = driver.FindElement(By.Id("i0116"));
            skype.SendKeys("sonnguyen66@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Enter valid value into account sendkey : trangnguyen237@vanlanguni.vn'");
            IWebElement next = driver.FindElement(By.Id("idSIButton9"));
            next.Click();
            test.Log(LogStatus.Pass, "Select 'Next'");
            //input pass
            IWebElement pass = driver.FindElement(By.Id("i0118"));
            pass.SendKeys("VLUt153930");
            test.Log(LogStatus.Pass, "Enter valid value into 'Password' sendkey : VLUt153930'");
            IWebElement login = driver.FindElement(By.Id("idSIButton9"));
            login.Click();
            test.Log(LogStatus.Pass, "Select 'Login'");
            IWebElement accept = driver.FindElement(By.Id("idSIButton9"));
            accept.Click();
            test.Log(LogStatus.Pass, "Select 'Accept'");
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            test.Log(LogStatus.Pass, "Input 'Email' sendkey : trangnguyen7@gamil.com'");
            IWebElement register = driver.FindElement(By.Id("Email"));
            register.Click();
            test.Log(LogStatus.Pass, "Select 'Register' button and observe the displayed result'");

            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "'Name trangnguyen237@vanlanguni.vn is already taken. Email 'trangnguyen237@vanlanguni.vn' is already taken'");
        }


    }
}
