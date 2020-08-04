using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {

        String URL = "http://eaapp.somee.com/";
        private IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            Login();
        }
        public void Login()
        {
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("UserName")).SendKeys("thejaswi");
            IWebElement login = driver.FindElement(By.Id("Password"));
            login.SendKeys("Sweety.1234");
            login.SendKeys(Keys.Enter);
            driver.Close();
        }

    }
}
