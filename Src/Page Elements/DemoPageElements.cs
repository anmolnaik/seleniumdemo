using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoApplication.Src.Page_Elements
{
    class DemoPageElements
    {
        public static string URL = "http://www.amazon.in";
        public static By SignIn = By.Id("signInSubmit");
        public static By YourOrder = By.XPath("//a[@id='nav-link-yourAccount']//span[@class='nav-line-2' and contains(text(),'Your Orders')]");
        public static By SignOut = By.XPath("//span[contains(text(),'Sign Out')]");
        public static By Username = By.Name("email");
        public static By Continue = By.Id("continue");
        public static By Password = By.Name("password");
        public static By UserLogin = By.XPath("//span[contains(text(),'Hello. Sign in')]");
        public static By SearchProduct = By.Name("field-keywords");
        public static By Search = By.XPath("//div[@class='nav-right']//input[@class='nav-input']");
        public static By ProductName = By.XPath("//h2[contains(text(),'Apple iPhone')]");
        public static By HomePagePrice = By.XPath("//ul[@id='s-results-list-atf']//li[@id='result_0']//span[@class='currencyINR']/parent::span");
        public static By HomePageProduct = By.XPath("//h2[contains(text(),'Realme U1 (Ambitious Black, 3GB RAM, 32GB Storage)')]");
        public static By ProductPagePrice = By.XPath("//span[@id='priceblock_ourprice']");
    }
}
