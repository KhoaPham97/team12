﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestFixture]
    [Parallelizable]
    public class CreatePlan : TestBase
    {
        [Test]
        public void plan()
        {
            IWebElement email = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs1.validate-input > input"));
            email.SendKeys("trangnguyen237@vanlanguni.vn");
            IWebElement pass = driver.FindElement(By.CssSelector("#loginForm > form > div.wrap-input100.rs2.validate-input > input"));
            pass.SendKeys("1234567890");
            IWebElement login = driver.FindElement(By.CssSelector("#loginForm > form > div.container-login100-form-btn > button"));
            login.Click();
            IWebElement plan = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-md-12 > div > div.box-header.with-border > div > button > i"));
            plan.Click();
            IWebElement newplan = driver.FindElement(By.CssSelector("#Title"));
            newplan.SendKeys("test create plan");
            IWebElement create = driver.FindElement(By.CssSelector("body > div > div.content-wrapper > section.content > div.col-md-12 > div > div.box-body > div > form > div > div > div > div.form-group > div > input"));
            create.Click();
        }
    }
}
