using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace BeeCeeAutoFramework
{
    public class Tests
    {
        private IWebDriver Driver;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void Close()
        {
            Driver.Dispose();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Console.WriteLine("Test1");
            Assert.Pass();
        }

        [Test]
        public void LaunchAndCloseBrowserWindow()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}