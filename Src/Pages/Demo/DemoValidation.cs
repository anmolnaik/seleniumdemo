using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumDemoApplication.Src.Page_Elements;
using NUnit.Framework;

namespace SeleniumDemoApplication.Src.Pages.Demo
{
    class DemoValidation
    {
        public void ValidateProduct(IWebDriver driver) => Assert.True(driver.FindElements(DemoPageElements.ProductName)!=null,"Iphone is not displayed.");

        internal void ValidateProductPrice()
        {
            throw new NotImplementedException();
        }

        public void ValidateProductPrice(decimal oldprice, decimal newPrice) => Assert.AreEqual(oldprice,newPrice,"Product price is not validated.");
    }
}
