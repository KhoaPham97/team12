using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestFixture]
    public class Report
    {
        public ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void StartReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\MyOwnReport.html";

            extent = new ExtentReports(reportPath, true);
            extent.AddSystemInfo("host name", "123");
            extent.LoadConfig(projectPath + "extebt-config.xml");
        }
        [Test]
        public void ReportPass()
        {
            test = extent.StartTest("Pass");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass,"Assert Pass as condition is True");
        }

        public void ReportFail()
        {
            test = extent.StartTest("Fail");
            Assert.IsTrue(false);
            test.Log(LogStatus.Pass, "Assert Pass as condition is False");
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

    }
}
