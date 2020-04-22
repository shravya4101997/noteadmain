using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class search : launch
    {
        By searching = By.XPath("//input[@placeholder='Search']");
        By clicksearch = By.XPath("//div[@id='search']//i[@class='fa fa-search']");

        public void searchmethod() //searching a product from search bar
        {
            driver.FindElement(searching).SendKeys("baby care");
            driver.FindElement(clicksearch).Click();
        }
    }
}