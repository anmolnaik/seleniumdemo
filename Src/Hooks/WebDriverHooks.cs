using OpenQA.Selenium;
using SeleniumDemoApplication.Src.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Src.Hooks
{
    [Binding]
    class WebDriverHooks
    {
        static WebDriverSetup webDriverSetup;

        [BeforeTestRun]
        public static void InitiateWebDriverSetup()
        {
            webDriverSetup = new WebDriverSetup();            
        }

        [BeforeFeature("chrome_setup_before_feature")]
        public static void LaunchDriver()
        {
            FeatureContext.Current.Add("driver", webDriverSetup.GetWebDriver());
        }

        [AfterFeature("close_current_browser")]
        public static void TearDown()
        {
            webDriverSetup.CloseWebDriver(FeatureContext.Current.Get<IWebDriver>("driver"));
        }
    }
}
