using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace lesson_first
{
    [TestClass]
    public class UnitTest1
    {
        private OpenQA.Selenium.IWebDriver driver;
        private WebDriverWait wait;

        [TestMethod]
        public void Start()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }
        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost/litecart/admin/login.php";
            driver.FindElement(OpenQA.Selenium.By.Name("username")).SendKeys("admin");
            driver.FindElement(OpenQA.Selenium.By.Name("password")).SendKeys("admin");
            driver.FindElement(OpenQA.Selenium.By.Name("login")).Click();
            wait.Until(ExpectedConditions.TitleIs("webdriver - поиск в Google"));
        }

        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }

}
