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

        public static By YourOrder = By.XPath("//a[@id='nav-link-yourAccount']//span[@class='nav-line-2' and contains(text(),'Your Orders')]");

        public static By SignOut = By.XPath("//span[contains(text(),'Sign Out')]");

        public static By Username = By.Name("email");

        public static By Continue = By.Id("continue");

        public static By Password = By.Name("password");

        public static By SignIn = By.XPath("//span[contains(text(),'Hello. Sign in')]");

        public static By SearchProduct = By.Name("field-keywords");

        public static By Search = By.XPath("//div[@class='nav-right']//input[@class='nav-input']");

        public static By ProductName = By.XPath("//h2[contains(text(),'Apple iPhone')]");

        public static By HomePagePrice = By.XPath("//ul[@id='s-results-list-atf']//li[@id='result_0']//span[@class='currencyINR']/parent::span");

        public static By HomePageProduct(string product) => By.XPath("//h2[contains(text(),'" + product + "')]");

        public static By ProductPagePrice = By.XPath("//span[@id='priceblock_dealprice']");

        public static By ProductCustomPrice = By.XPath("//div[@id='sc-buy-box']//span[@class='currencyINR']/parent::span");

        public static By ProductQuantityOnProductPage = By.Name("quantity");

        public static By AddToCartFromProductPage = By.XPath("//input[@name='submit.add-to-cart']");

        public static By AddToCartButton = By.ClassName("a-button-text");

        public static By DeleteFromCart = By.XPath("//span[@class='a-declarative']//input[contains(@name,'submit.delete')]");

        public static By EmptyCartMessageInCart = By.XPath("//div[@id='sc-active-cart']//h1");

        public static By BrandFilterSelect(string product) => By.XPath("//span[contains(text(),'" + product + "')]//parent::span[@class='a-label a-checkbox-label']");

        public static By BrandList(string product) => By.XPath("//h2[contains(text(),'" + product + "')]");

        public static By PriceFilterSelect => By.XPath("//a[@class='a-link-normal s-ref-text-link']//span[contains(text(),'Under ₹1,000')]");

        public static By LoginButton => By.Id("signInSubmit");

        public static By LoginAndSecurity => By.XPath("//h2[contains(text(),'Login & security')]");

        public static By ClickOnNameEdit => By.Id("auth-cnep-edit-name-button");

        public static By SendNameToEdit => By.Id("ap_customer_name");

        public static By ClickOnSaveChanges => By.XPath("//input[@class='a-button-input']");

        public static By EditSuccessMessage => By.XPath("//span[contains(text(),'You successfully changed your account!')]");

        public static By UpdateAccoutYourOrder => By.XPath("//span[@class='nav-line-2' and contains(text(),'Your Orders')]");

        public static By InternalLinkYourAccount => By.XPath("//span[@class='nav-text' and contains(text(),'Your Account')]");

        public static By EditPasswordOld => By.Id("ap_password");

        public static By EditPasswordNew => By.Id("ap_password_new");

        public static By EditPasswordNewCheck => By.Id("ap_password_new_check");

        public static By LoginSecurityDoneButton => By.LinkText("Done");

        public static By LogoPrimeLink => By.LinkText("Try Prime");

        public static By DropDownPrimeLink => By.XPath("//div[@id='nav-tools']//span[contains(text(),'Prime')]");

        public static By AddToCartButtonFromWishList => By.XPath("//span[@class='a-button-inner']//a[contains(text(),'Add to Cart')]");

        public static By AddToCartFromWishListMessage => By.XPath("//h4[contains(text(),'Added to Cart')]");

        public static By CartOnHomePage => By.XPath("//span[contains(text(),'Cart')]");

        public static By ProductOldPrice => By.XPath("//div[@class='sc-list-item-content']//span[contains(@class,'sc-price')]");

        public static By LinkToDeleteFromCart => By.XPath("//input[contains(@name,'submit.delete')]");

        public static By InternalLinkYourPrimeVideo => By.XPath("//span[@class='nav-text' and contains(text(),'Your Prime Video')]");

        public static By ValidateProductInCart(string product) => By.XPath($"//span[contains(@class,'sc-product-title') and contains(text(),'{product}')]");

        public static By ClickOnPasswordEdit = By.Id("auth-cnep-edit-password-button");

        public static By IncorrectPassword = By.XPath("//h4[contains(text(),'There was a problem')]");

        public static By IncorrectEmail = By.XPath("//h4[contains(text(),'There was a problem')]");

        public static By ProductNameInWishList(string product) => By.PartialLinkText(product);

        public static By ViewWishList = By.XPath("//span[contains(text(),'View Wish List')]");

        public static By ProductPrice = By.XPath("//span[contains(@class,'s-price')]");

        public static By PriceFilterName = By.XPath("//h4[contains(text(),'Price')]");

        public static By AddToWishListButton = By.XPath("//input[@id='add-to-wishlist-button-submit']");

        public static By OperatingSystemName(string osName) => By.XPath($"//span[text()='{osName}']");
    }
}
