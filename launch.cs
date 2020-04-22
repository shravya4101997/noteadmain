using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class launch
    {

        public static IWebDriver driver;
        public static void Launchmethod() //launching url and maximizing window
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); 
             driver = new ChromeDriver(options);


            driver.Url ="https://www.menmoms.in/";
           driver.Manage().Window.Maximize();
        }
}
}
