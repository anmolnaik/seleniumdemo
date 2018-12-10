using OpenQA.Selenium;
using SeleniumDemoApplication.Src.Events;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Src.Pages.Demo
{
    [Binding]
    class DemoStepDefinitions
    {
        private IWebDriver driver;
        private DemoAction demoAction;
        private DemoValidation demoValidation;
        public DemoStepDefinitions()
        {
            driver = FeatureContext.Current.Get<IWebDriver>("driver");
            demoAction = new DemoAction();
            demoValidation = new DemoValidation();
        }

        [Given(@"Go To Login Page")]
        public void GivenGoToLoginPage()
        {
            demoAction.OpenUrl(driver);
            demoAction.LogIn(driver);
        }    

        [Then(@"Enter (.*) and (.*)")]
        public void ThenEnterAnd(string username, string password)
        {
            demoAction.EnterUsername(driver,username);
            demoAction.ClickContinueLogin(driver);
            demoAction.EnterPassword(driver,password);                        
        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            demoAction.ClickLogin(driver);
        }

        [Then(@"Log out from website")]
        public void ThenLogOutFromWebsite()
        {
            demoAction.ClickLogOut(driver);
        }

        [Then(@"Validate incorrect email error message")]
        public void ThenValidateIncorrectEmailErrorMessage()
        {          
            demoValidation.ValidateIncorrectEmailError(driver);
        }

        [Then(@"Validate incorrect password error message")]
        public void ThenValidateIncorrectPasswordErrorMessage()
        {
            demoValidation.ValidateIncorrectPassword(driver);
        }

        [Given(@"Open Website Url")]
        public void GivenOpenWebsiteUrl()
        {
            demoAction.OpenUrl(driver);
        }

        [Then(@"Search for (.*)")]
        public void ThenSearchForPhone(string product)
        {
            demoAction.SearchProduct(driver, product);
        }


        [When(@"Click on Search button")]
        public void WhenClickOnSearchButton()
        {
            demoAction.ClickOnSearch(driver);
        }

        [Then(@"Validate first product found")]
        public void ThenValidateFirstProductFound()
        {
            demoValidation.ValidateProduct(driver);
        }

        [Then(@"Get the price on current product (.*)")]
        public void ThenGetThePriceOnCurrentProduct(string product)
        {
            ScenarioContext.Current.Add("firstPrice", demoAction.GetProductPrice(driver));
            demoAction.ClickOnProductPage(driver,product);
        }

        [Then(@"validate on product page")]
        public void ThenValidateOnProductPage()
        {
            driver.SwitchTab();               
            demoValidation.ValidateProductPrice(ScenarioContext.Current.Get<decimal>("firstPrice"), demoAction.GetProductPagePrice(driver));
            driver.CloseTabAndSwitchBack();
        }

        [When(@"Update product quantity")]
        public void WhenUpdateProductQuantity()
        {
            driver.SwitchTab();
            demoAction.UpdateProductQuantity(driver);
        }

        [When(@"Product added to cart")]
        public void WhenProductAddedToCart()
        {                       
            demoAction.AddToCartFromProduct(driver);
        }        

        [Then(@"Validate updated product price")]
        public void ThenValidateUpdatedProductPrice()
        {
            demoAction.GoToCartButton(driver);
            demoValidation.ValidateUpdatedCartProductPrice(ScenarioContext.Current.Get<decimal>("firstPrice"),demoAction.GetProductUpdatePriceCart(driver));            
        }
        [Then(@"Select product (.*)")]
        public void ThenSelectForProduct(string product)
        {
            demoAction.ClickOnProductPage(driver, product);
            driver.SwitchTab();
        }

        [When(@"Product added to the cart")]
        public void WhenProductAddedToTheCart()
        {            
            demoAction.AddToCartFromProduct(driver);
        }

        [Then(@"Delete product added to cart")]
        public void ThenDeleteProductAddedToCart()
        {
            demoAction.GoToCartButton(driver);
            demoAction.DeleteFromCart(driver);
        }

        [Then(@"Validate Cart is Empty")]
        public void ThenValidateCartIsEmpty()
        {
            demoValidation.ValidateCartEmpty(driver,demoAction.EmptyCartMessage(driver));
        }

        [Then(@"Select filter for (.*)")]
        public void ThenSelectFilterFor(string product)
        {
            demoAction.MoveAndSelectFilterForBrand(driver,product);
        }
            
        [Then(@"Validate list of (.*) products")]
        public void ThenValidateListOfProducts(string product)
        {
            demoValidation.ValidateBrandFilterList(driver,product);            
        }

        [Then(@"Validate price list of product under Under ₹1,000")]
        public void ThenValidatePriceListOfProductUnderUnder()
        {
            demoAction.ClickOnPriceRange(driver);
            demoValidation.ValidatePriceFilterList(driver);
        }

        [Then(@"Product added to wishlist (.*)")]
        public void WhenProductAddedToWishlist(string product)
        {
            driver.SwitchTab();
            demoAction.AddToWishListFromProduct(driver);
            demoAction.ClickOnViewWishList(driver);
            demoValidation.ValidateProductInWishList(driver,product);
        }
        [Then(@"Enter incorrect emailid (.*)")]
        public void ThenEnterIncorrectEmailid(string username)
        {
            demoAction.EnterUsername(driver, username);
            demoAction.ClickContinueLogin(driver);
            
        }

        [Then(@"Set incorrect username (.*) and password  (.*)")]
        public void ThenSetIncorrectUsernameAndPassword(string username, string password)
        {
            demoAction.EnterUsername(driver, username);
            demoAction.ClickContinueLogin(driver);
            demoAction.EnterPassword(driver, password);
        }
        [When(@"Enter blank Email id")]
        public void WhenEnterBlankEmailId()
        {
            demoAction.EnterUsername(driver, "");
            demoAction.ClickContinueLogin(driver);
        }

        [Then(@"I am not able to login")]
        public void ThenIAmNotAbleToLogin()
        {
            demoAction.ClickContinueLogin(driver);
            demoValidation.ValidateBlankEmail(driver);
        }
        [When(@"I clicked on Your Orders")]
        public void WhenIClickedOnYourOrders()
        {
            demoAction.ClickOnYourOrder(driver);
        }

        [When(@"I clicked on login and security")]
        public void WhenIClickedOnLoginAndSecurity()
        {
            demoAction.ClickAccountLoginAndSecurity(driver);
        }

        [Then(@"I update (.*)")]
        public void ThenIUpdateName(string name)
        {
            demoAction.EditName(driver);
            demoAction.EditNameSendData(driver, name);
            demoAction.EditNameSaveChanges(driver);
            demoValidation.ValidateEditSuccessMessage(driver);
            demoAction.LoginSecurityDone(driver);
        }

        [Then(@"Account password update")]
        public void ThenAccountPasswordUpdate()
        {

            demoAction.EditPassword(driver);
            demoAction.EditPasswordUpdate(driver);
            demoAction.EditPasswordSaveChanges(driver);
            demoValidation.ValidateEditSuccessMessage(driver);
            demoAction.LoginSecurityDone(driver);
        }

        [Then(@"Home page logo prime link")]
        public void GivenHomePageLogoPrimeLink()
        {
            demoAction.HomePageLogoPrimeLink(driver);
            demoAction.BackToHomePage(driver);
        }

        [Then(@"Home page prime dropdown link")]
        public void ThenHomePagePrimeDropdownLink()
        {
            demoAction.HomePageDropDownLink(driver);
            demoAction.BackToHomePage(driver);

        }

        [Then(@"Home Page Prime vedio link")]
        public void ThenHomePagePrimeVedioLink()
        {            
            demoAction.HomePagePrimeVideoLink(driver);           
        }

        [Then(@"Add product to cart from wishlist")]
        public void ThenAddProductToCartFromWishlist()
        {
            demoAction.AddToCartFromProductFromWishList(driver);            
        }
        [Then(@"Validate message Product added to cart")]
        public void ThenValidateMessageProductAddedToCart()
        {
            demoValidation.ValidateProductInWishListAddedToCart(driver);
        }
        [Then(@"Go to cart from home page")]
        public void ThenGoToCartFromHomePage()
        {
            demoAction.ClickOnCartOnHomePage(driver);
        }

        [Then(@"Validate and remove product from cart (.*)")]
        public void ThenValidateAndRemoveProductFromCart(string product)
        {
            demoValidation.ValidateProductInWishListAddedToCart(driver,product);
            demoAction.DeleteProductFromCart(driver);
        }        

    }
}
