using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Src.Pages.Shared_Steps
{
    [Binding]
    class DemoSharedSteps : Steps
    {
        [Given(@"Go to url and login username : (.*) password : (.*)")]
        public void GivenGoToUrlAndLogin(string username, string password)
        {
            Given("Go To Login Page");
            Then($"Enter {username} and {password}");
            When("I press login");
        }              
    }
}
