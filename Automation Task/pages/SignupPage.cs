using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Task.pages
{
    public class SignupPage
    {
        IWebElement signupMenu => driver.FindElement(By.XPath("//a[text()='Sign Up']"));
        IWebElement inputNumber => driver.FindElement(By.XPath("//input[@placeholder='Please enter your phone number']"));
        IWebElement modalCheckBox => driver.FindElement(By.XPath("//label[contains(@class,'iweb-checkbox-lazada')]"));
        IWebElement btnSend => driver.FindElement(By.XPath("//button[@type='button']"));


        IWebDriver driver;
        public SignupPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void doSignup(string phoneNumber) { 
            signupMenu.Click();
            Thread.Sleep(1000);
            inputNumber.SendKeys(phoneNumber);
            Thread.Sleep(1000);
            modalCheckBox.Click();
            Thread.Sleep(1000);
            btnSend.Click();
        }

    }
}
