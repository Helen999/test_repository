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
            driver.Url = "http://google.com";
            driver.FindElement(OpenQA.Selenium.By.Name("q")).SendKeys("webdriver");
            driver.FindElement(OpenQA.Selenium.By.Name("btng")).Click();
            wait.Until(ExpectedConditions.TitleIs("webdriver - поиск в Google"));
        }

        public void stop()
        {
            driver.Quit();
            driver = null;
        }
    }

}
