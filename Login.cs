using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Login : launch
    {
        By Account = By.XPath("//a[@class='my-account-link dropdown-toggle']//i[@class='fa fa-user']");
        By login = By.XPath("//div[@class='my-account dropdown open']//a[contains(text(),'Login')]");
        By loginwithmail = By.XPath("//a[contains(text(),'Login with email')]");
        By email = By.XPath("//input[@id='input-email']");
        By password = By.XPath("//input[@id='input-password']");
        By loginbutton = By.XPath("//div[@class='form-group text-center']//input[@class='btn btn-danger btn-den']");
       
        public void loginmethod() //Existing user login
        {

            Thread.Sleep(2000);
            driver.FindElement(Account).Click();
            driver.FindElement(login).Click();
            driver.FindElement(loginwithmail).Click();
            driver.FindElement(email).SendKeys("shravyashastri9@gmail.com");
            driver.FindElement(password).SendKeys("9448729375");
            driver.FindElement(loginbutton).Click();


        }
    }
}