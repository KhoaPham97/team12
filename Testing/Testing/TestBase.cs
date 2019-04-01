using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://teamfighter.azurewebsites.net");
            Console.WriteLine("Open URL");
        }

        [OneTimeSetUp]
        public void StartReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\MyReport.html";

            extent = new ExtentReports(reportPath, true);
            extent.AddSystemInfo("host name", "123");
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
                test.Log(LogStatus.Fail, status + errorMessage);
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
            driver.Close();
            Console.WriteLine("Close in browser");
        }
       
    }
}
