using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestFixture]
    [Parallelizable]
    public class LogoutTest : TestBase
    {
        [Test]
        public void TC_FUC_MO01_16()
        {
            Console.WriteLine("TC_FUC_MO01_16");
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement button = driver.FindElement(By.CssSelector("body > div.wrapper > header > nav > div > ul > li.dropdown.user.user-menu > a > span"));
            button.Click();
            IWebElement logout = driver.FindElement(By.CssSelector("#logoutForm > div > a"));
            logout.Click();

        }
       
    }
}
