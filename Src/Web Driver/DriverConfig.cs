using OpenQA.Selenium;
using System;

namespace SeleniumDemoApplication.Src.Web_Driver
{
    public static class DriverConfig
    {
        
        public static void DriverMaximizeSetup(this IWebDriver driver)
        {                        
            if (int.Parse(((IJavaScriptExecutor)driver).ExecuteScript("return screen.availWidth").ToString()) < 1382 && int.Parse(((IJavaScriptExecutor)driver).ExecuteScript("return screen.availHeight").ToString()) < 744)
            {
                driver.Manage().Window.Maximize();
                Console.WriteLine("New :"+driver.Manage().Window.Size);
            }          
        }
    }
}
