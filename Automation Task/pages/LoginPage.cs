using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Task.pages
{
    public class LoginPage
    {
        IWebElement loginMenu => driver.FindElement(By.XPath("//a[text()='Login']"));
        IWebElement inputEmail => driver.FindElement(By.XPath("//input[@placeholder='Please enter your Phone or Email']"));
        IWebElement inputPassword => driver.FindElement(By.XPath("//input[@placeholder='Please enter your password']"));
        IWebElement btnSubmit => driver.FindElement(By.XPath("//button[@type='button']"));
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void doLogin(string email, String password)
        {
            loginMenu.Click();
            Thread.Sleep(1000);
            inputEmail.SendKeys(email);
            Thread.Sleep(1000);
            inputPassword.SendKeys(password);
            Thread.Sleep(2000);
            btnSubmit.Click();
        }

        public void loginAssertion()
        {   
            //String getCurrentUrl = driver.Url;


        }
    }
}
