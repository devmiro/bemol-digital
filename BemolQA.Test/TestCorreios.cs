using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace BemolQA.Test
{
    public class TestCorreios : IDisposable
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        
        public TestCorreios()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
                        
        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.Equal("", verificationErrors.ToString());
        }
        
        [Fact]
        public void BuscaCep()
        {
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br/sistemas/buscacep/");
            driver.FindElement(By.Name("relaxation")).SendKeys("69005-040");
            driver.FindElement(By.XPath("//input[@value='Buscar']")).Click();
            Thread.Sleep(5*1000);
            driver.Navigate().Back();
            driver.FindElement(By.Name("relaxation")).Clear();           
            Thread.Sleep(10*1000);
            
        }

        [Fact]
        public void BuscaLoja()
        {
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br/sistemas/buscacep/");
            driver.FindElement(By.Name("relaxation")).SendKeys("Lojas Bemol");
            driver.FindElement(By.XPath("//input[@value='Buscar']")).Click();

            Thread.Sleep(10*1000);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
