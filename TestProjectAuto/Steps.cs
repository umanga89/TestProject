using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestProjectAuto
{
    [Binding]
    class Steps
    {
        public static IWebDriver driver;

        [Given(@"I've launched (.*) browser")]
        public void GivenIVeLauchedChromeBrowser(string browser)
        {
            driver = new ChromeDriver(@"C:\chromedriver");
        }

        [Given(@"I'm in google home page")]
        public void GivenIMInGoogleHomePage()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Quit();
        }
    }

}
//this is a test comment
