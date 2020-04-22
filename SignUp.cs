using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class SignUp : launch
    {
        public static By signindropdown = By.XPath("//span[contains(text(),'Hello, Sign in')]");
        public static By createaccount = By.Id("createAccountSubmit");
        public static By name = By.Id("ap_customer_name");
        public static By email = By.Id("ap_email");
        public static By password = By.Id("ap_password");
        public static By reenter = By.Id("ap_password_check");
        public static By submit = By.Id("continue");

        public static void Signupmethod()
        {
            driver.FindElement(signindropdown).Click();
            driver.FindElement(createaccount).Click();
            driver.FindElement(name).SendKeys("shravya");
            driver.FindElement(email).SendKeys("shravyashastri9@gmail.com");
            driver.FindElement(password).SendKeys("9448729375shastri");
            driver.FindElement(reenter).SendKeys("9448729375shastri");
            driver.FindElement(submit).Click();
        }
    }
}