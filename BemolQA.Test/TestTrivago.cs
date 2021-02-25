using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace BemolQA.Test
{
    public class TestTrivago : IDisposable
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        public TestTrivago()
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
        public void TheTrivagoTest()
        {
            driver.Navigate().GoToUrl("https://www.trivago.com.br/");
            driver.FindElement(By.Id("querytext")).SendKeys("Manaus");
            Thread.Sleep(5 * 1000);
            driver.FindElement(By.XPath("//span[@class='search-button__label']")).Click();
            Thread.Sleep(5 * 1000);            
            new SelectElement(driver.FindElement(By.Id("mf-select-sortby"))).SelectByValue("7");

            //Garantia de que é o primeiro elemento
            var firstHotel = driver.FindElement(By.Id("js_itemlist"))
                            .FindElements(By.TagName("li")).First();

            
            Assert.NotNull(firstHotel.FindElement(By.XPath("//*[@data-qa='item-name']")).Text);

            Assert.NotNull(firstHotel.FindElement(By.XPath("//*[@data-qa='recommended-price']")).Text);

            //Também acaba trazendo o primeiro elemento encontrado
            Assert.NotNull(driver.FindElement(By.XPath("//*[@class='rating-number']")).Text);



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

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

    }
}