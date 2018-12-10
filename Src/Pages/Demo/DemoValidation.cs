using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumDemoApplication.Src.Page_Elements;
using NUnit.Framework;
using SeleniumDemoApplication.Src.Events;
using System.Text.RegularExpressions;
using System.Threading;

namespace SeleniumDemoApplication.Src.Pages.Demo
{
    class DemoValidation
    {
        public void ValidateProduct(IWebDriver driver) => Assert.True(driver.FindElements(DemoPageElements.ProductName)!=null,"Iphone is not displayed.");

        public void ValidateProductPrice(decimal oldPrice, decimal newPrice) => Assert.AreEqual(oldPrice,newPrice,"Product price is not validated.");

        public void ValidateUpdatedCartProductPrice(decimal oldPrice, decimal newPrice)
        {
            Thread.Sleep(4000);
            Assert.AreEqual((oldPrice * 2), newPrice, "Product price is not updated");

        }
        public void ValidateCartEmpty(IWebDriver driver,string message) => Assert.AreEqual("Your Shopping Cart is empty.", message,"Cart is not empty");

        public string ValidateBrandFilterList(IWebDriver driver, string product) => driver.FindElement(DemoPageElements.BrandList(product)).Text;

        public void ValidatePriceFilterList(IWebDriver driver)
        {
            Thread.Sleep(4000);                       
            Assert.LessOrEqual(int.Parse(driver.FindElement(DemoPageElements.ProductPrice).Text), 1000);
        }

        public void ValidateProductInWishList(IWebDriver driver, string product) => Assert.NotNull(driver.FindElement(DemoPageElements.ProductNameInWishList(product)));

        public void ValidateIncorrectPassword(IWebDriver driver) => Assert.NotNull(driver.FindElement(DemoPageElements.IncorrectPassword));

        public void ValidateIncorrectEmailError(IWebDriver driver) => Assert.NotNull(driver.FindElement(DemoPageElements.IncorrectEmail));

        public void ValidateBlankEmail(IWebDriver driver) => Assert.IsNotNull(driver.FindElement(DemoPageElements.Username));

        public void ValidateEditSuccessMessage(IWebDriver driver) => Assert.IsNotNull(driver.FindElement(DemoPageElements.EditSuccessMessage));

        public void ValidateProductInWishListAddedToCart(IWebDriver driver) => Assert.IsNotNull(driver.FindElement(DemoPageElements.AddToCartFromWishListMessage));

        public void ValidateProductInWishListAddedToCart(IWebDriver driver, string product) => Assert.IsNotNull(driver.FindElement(DemoPageElements.ValidateProductInCart(product)));
    }
}
