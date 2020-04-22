using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3.PAGEOBJECTS
{
    class logout:launch
    {
        By logoutdropdown = By.XPath("//a[@class='my-account-link dropdown-toggle']//i[@class='fa fa-user']");
        By logoutfield = By.XPath("//div[contains(@class,'my-account dropdown open')]//a[contains(text(),'Logout')]");

        public void logoutmethod() //logout 
        {
            Thread.Sleep(2000);
            driver.FindElement(logoutdropdown).Click();
            driver.FindElement(logoutfield).SendKeys(Keys.Enter);
            driver.Quit();
        }
    }
}
