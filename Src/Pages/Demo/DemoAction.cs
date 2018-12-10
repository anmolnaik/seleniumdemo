using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumDemoApplication.Src.Events;
using SeleniumDemoApplication.Src.Page_Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Src.Pages.Demo
{
    class DemoAction
    {                     
        public void ClickLogin(IWebDriver driver) => driver.FindElement(DemoPageElements.LoginButton).Click();
        public void ClickLogOut(IWebDriver driver)
        {
            driver.MoveToElement(driver.FindElement(DemoPageElements.YourOrder));
            driver.MoveToElementAndClick(driver.FindElement(DemoPageElements.SignOut));
        }
        public void ClickContinueLogin(IWebDriver driver) => driver.FindElement(DemoPageElements.Continue).Click();
        public void OpenUrl(IWebDriver driver) => driver.Navigate().GoToUrl(DemoPageElements.URL);
        public void EnterPassword(IWebDriver driver,string password) => driver.FindElement(DemoPageElements.Password).SendKeys(password);
        public void LogIn(IWebDriver driver) => driver.FindElement(DemoPageElements.SignIn).Click();
        public void EnterUsername(IWebDriver driver, string username) => driver.FindElement(DemoPageElements.Username).SendKeys(username);
        public void SearchProduct(IWebDriver driver,string product) => driver.FindElement(DemoPageElements.SearchProduct).SendKeys(product);
        public void ClickOnSearch(IWebDriver driver) => driver.FindElement(DemoPageElements.Search).Click();
        public decimal GetProductPrice(IWebDriver driver) => Convert.ToDecimal(driver.FindElement(DemoPageElements.HomePagePrice).Text);
        public void ClickOnProductPage(IWebDriver driver, string product) => driver.FindElement(DemoPageElements.HomePageProduct(product)).Click();
        public decimal GetProductPagePrice(IWebDriver driver) => Convert.ToDecimal(driver.FindElement(DemoPageElements.ProductPagePrice).Text);
        public void UpdateProductQuantity(IWebDriver driver) => driver.FindElement(DemoPageElements.ProductQuantityOnProductPage).SendKeys("2");
        public void AddToCartFromProduct(IWebDriver driver) => driver.FindElement(DemoPageElements.AddToCartFromProductPage).Click();
        public void GoToCartButton(IWebDriver driver) => driver.FindElement(DemoPageElements.AddToCartButton).Click();
        public decimal GetProductUpdatePriceCart(IWebDriver driver) => Convert.ToDecimal(driver.FindElement(DemoPageElements.ProductCustomPrice).Text);
        public void DeleteFromCart(IWebDriver driver) => driver.FindElement(DemoPageElements.DeleteFromCart).Click();
        public string EmptyCartMessage(IWebDriver driver) => driver.FindElement(DemoPageElements.EmptyCartMessageInCart).Text;

        public void MoveAndSelectFilterForBrand(IWebDriver driver, string product) => driver.MoveToElementAndClick(driver.FindElement(DemoPageElements.BrandFilterSelect(product)));
        public void ClickOnPriceRange(IWebDriver driver)
        {
            driver.MoveToElement(driver.FindElement(DemoPageElements.PriceFilterName));
            driver.FindElement(DemoPageElements.PriceFilterSelect).Click();
        }

        public void AddToWishListFromProduct(IWebDriver driver) => driver.FindElement(DemoPageElements.AddToWishListButton).Click();

        public void ClickOnViewWishList(IWebDriver driver) => driver.FindElement(DemoPageElements.ViewWishList).Click();

        public void ClickOnYourOrder(IWebDriver driver)
        {
            driver.MoveToElement(driver.FindElement(DemoPageElements.UpdateAccoutYourOrder));
            Thread.Sleep(1000);
            driver.FindElement(DemoPageElements.InternalLinkYourAccount).Click();
        }
            

        public void ClickAccountLoginAndSecurity(IWebDriver driver) => driver.FindElement(DemoPageElements.LoginAndSecurity).Click();

        public void EditName(IWebDriver driver)
        {
            Thread.Sleep(4000);
            driver.FindElement(DemoPageElements.ClickOnNameEdit).Click();
        }


        public void EditNameSendData(IWebDriver driver, string name)
        {
            driver.FindElement(DemoPageElements.SendNameToEdit).Clear();
            driver.FindElement(DemoPageElements.SendNameToEdit).SendKeys(name);
        }
        public void EditNameSaveChanges(IWebDriver driver)
        {
            if (driver.FindElement(DemoPageElements.ClickOnSaveChanges).Displayed)
            {
                Thread.Sleep(2000);
                driver.FindElement(DemoPageElements.ClickOnSaveChanges).Click();                
            }
            
        }

        public void EditPassword(IWebDriver driver) => driver.FindElement(DemoPageElements.ClickOnPasswordEdit).Click();

        public void EditPasswordUpdate(IWebDriver driver)
        {
            driver.FindElement(DemoPageElements.EditPasswordOld).SendKeys("Anmol@922");
            driver.FindElement(DemoPageElements.EditPasswordNew).SendKeys("Anmol@922");
            driver.FindElement(DemoPageElements.EditPasswordNewCheck).SendKeys("Anmol@922");
        }
        public void EditPasswordSaveChanges(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(DemoPageElements.ClickOnSaveChanges).Click();
        }
        public void LoginSecurityDone(IWebDriver driver) => driver.FindElement(DemoPageElements.LoginSecurityDoneButton).Click();

        public void HomePageLogoPrimeLink(IWebDriver driver) => driver.FindElement(DemoPageElements.LogoPrimeLink).Click();

        public void HomePageDropDownLink(IWebDriver driver) => driver.FindElement(DemoPageElements.DropDownPrimeLink).Click();

        public void HomePagePrimeVideoLink(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.MoveToElement(driver.FindElement(DemoPageElements.YourOrder));
            driver.FindElement(DemoPageElements.InternalLinkYourPrimeVideo).Click();
        }

        public void BackToHomePage(IWebDriver driver) => driver.Navigate().Back();

        public void AddToCartFromProductFromWishList(IWebDriver driver) => driver.FindElement(DemoPageElements.AddToCartButtonFromWishList).Click();

        public void ClickOnCartOnHomePage(IWebDriver driver) => driver.FindElement(DemoPageElements.CartOnHomePage).Click();

        public void DeleteProductFromCart(IWebDriver driver) => driver.FindElement(DemoPageElements.LinkToDeleteFromCart).Click();
    }
}
