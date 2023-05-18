using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace TestProjectCelinium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        IWebDriver driver;
        GoogleSearchPage searchPage;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            driver = new EdgeDriver();
        }
        [SetUp]
        public void Setup()
        {

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        }

        [Test]
        public void SeleniumTesting()
        {
            searchPage = new(driver);
            searchPage.SearchBox.SendKeys("Selenium");
            searchPage.SearchButton.Click();
            var searchQuery = driver.FindElement(By.Name("q")).GetAttribute("value");
            Console.WriteLine(searchQuery);
            Assert.Pass();
        }
        [Test]
        public void SeleniumTesting1()
        {
            searchPage = new(driver);
            searchPage.SearchBox.SendKeys("Tears of the kingdom");
            searchPage.SearchButton.Click();
            var searchQuery = driver.FindElement(By.Name("q")).GetAttribute("value");
            Console.WriteLine(searchQuery);
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}