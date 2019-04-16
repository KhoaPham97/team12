﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Testing
{
    public class TestBase
    {
        static void Main(string[] args)
        {
        }

        public ExtentReports extent;
        public ExtentTest test;

        protected IWebDriver driver;


        public void SetUp(String browserName)
        {
            if (browserName.Equals("ie"))
                driver = new InternetExplorerDriver();
            else if (browserName.Equals("chrome"))
                driver = new ChromeDriver();
            else if (browserName.Equals("firefox"))
                driver = new FirefoxDriver();
            else
                driver = new OperaDriver();

            driver.Navigate().GoToUrl("https://teamfighter.azurewebsites.net");
            Console.WriteLine("Open URL");

        }

        [OneTimeSetUp]
        public void StartReport()
        {
            string hostname = Dns.GetHostName();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\MyReport.html";

            extent = new ExtentReports(reportPath, true);
            extent.AddSystemInfo("Host name", hostname);
            extent.AddSystemInfo("Browser", "Google Chrome");
            extent.LoadConfig(projectPath + "extebt-config.xml");
        }

        [TearDown]
        public void Result()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, "Test ended with "+ status +Environment.NewLine + errorMessage);
            }
            else
            {
                test.Log(LogStatus.Pass, "Test ended with "+ status +  errorMessage);
            }
            extent.EndTest(test);
        }
        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }

        [TearDown]
        public void ClearUp()
        {
            driver.Quit();
            Console.WriteLine("Close in browser");
        }

        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = AutomationSetting.BrowserToRunWith.Split(',');

            foreach (String b in browsers)
            {
                yield return b;
            }

        }


    }
}