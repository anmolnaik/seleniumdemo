using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoApplication.Src.Events
{
    public static class SwitchEvents
    {
        public static void SwitchTab(this IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public static void CloseTabAndSwitchBack(this IWebDriver driver)
        {
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }
    }
}
