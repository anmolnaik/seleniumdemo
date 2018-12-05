using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumDemoApplication.Src.Events;
using SeleniumDemoApplication.Src.Page_Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Src.Pages.Demo
{
    class DemoAction
    {                     
        public void ClickLogin(IWebDriver driver) => driver.FindElement(DemoPageElements.SignIn).Click();
        public void ClickLogOut(IWebDriver driver)
        {
            driver.MoveToElement(driver.FindElement(DemoPageElements.YourOrder));
            driver.MoveToElementAndClick(driver.FindElement(DemoPageElements.SignOut));
        }
        public void ClickContinueLogin(IWebDriver driver) => driver.FindElement(DemoPageElements.Continue).Click();
        public void OpenUrl(IWebDriver driver) => driver.Navigate().GoToUrl(DemoPageElements.URL);
        public void EnterPassword(IWebDriver driver,string password) => driver.FindElement(DemoPageElements.Password).SendKeys(password);
        public void LogIn(IWebDriver driver) => driver.FindElement(DemoPageElements.UserLogin).Click();
        public void EnterUsername(IWebDriver driver, string username) => driver.FindElement(DemoPageElements.Username).SendKeys(username);
        public void SearchProduct(IWebDriver driver,string product) => driver.FindElement(DemoPageElements.SearchProduct).SendKeys(product);
        public void ClickOnSearch(IWebDriver driver) => driver.FindElement(DemoPageElements.Search).Click();
        public decimal GetProductPrice(IWebDriver driver) => Convert.ToDecimal(driver.FindElement(DemoPageElements.HomePagePrice).Text);
        public void ClickOnProductPage(IWebDriver driver, string product) => driver.FindElement(DemoPageElements.HomePageProduct).Click();
        public decimal GetProductPagePrice(IWebDriver driver) => Convert.ToDecimal(driver.FindElement(DemoPageElements.ProductPagePrice).Text);
    }
}
