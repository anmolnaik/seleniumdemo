using NUnit.Framework;
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

        [Then(@"Validate The Amazon Logo")]
        public void ThenValidateTheAmazonLogo()
        {
            demoAction.ClickLogOut(driver);
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

    }
}
