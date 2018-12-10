using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace SeleniumDemoApplication.Src.Events
{
    public static class HoverEvents
    {        
        public static void MoveToElement(this IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public static void MoveToElementAndClick(this IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Click();
            actions.Build().Perform();
        }
    }
}
