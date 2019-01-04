using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumDemoApplication.Src.Events
{
    public static class HoverEvents
    {
        public static void MoveToElement(this IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
            Thread.Sleep(1000);
        }

        public static void MoveToElementAndClick(this IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Click();
            actions.Build().Perform();
        }

        public static void JScriptMoveToElement(this IWebDriver driver, IWebElement element) => ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
    }
}
