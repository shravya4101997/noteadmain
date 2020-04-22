using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class addcart:launch
    {
       
        By product = By.XPath("//body[contains(@class,'body-header-type- product-search')]//div[contains(@class,'row')]//div[contains(@class,'row')]//div[1]//div[1]//div[1]//a[1]//img[1]");
        By addcartproduct= By.XPath("//button[@id='button-cart']");
       


        public void addcartmethod() //adding a product to cart
        {
            Thread.Sleep(2000);
            driver.FindElement(product).Click();
            driver.FindElement(addcartproduct).SendKeys(Keys.Enter);


        }
    }
}
