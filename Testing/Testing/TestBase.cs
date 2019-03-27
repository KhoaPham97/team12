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
    public class TestBase
    {
        static void Main(string[] args)
        {
        }

        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://teamfighter.azurewebsites.net");
            Console.WriteLine("Open URL");
        }

        [TearDown]
        public void ClearUp()
        {
            driver.Close();
            Console.WriteLine("Close in browser");
        }

    }
}
