using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Task.pages
{
    public class CheckoutPage
    {
        IWebElement cartBtn=> driver.FindElement(By.XPath("//span[@class='cart-icon-daraz']"));
        IWebElement btnSelect => driver.FindElement(By.XPath("//div[@id='listHeader_H']//label[contains(@class,'list-header-checkbox')]"));
        IWebElement btnCheckout => driver.FindElement(By.XPath("//button[@class='next-btn next-btn-primary next-btn-large checkout-order-total-button automation-checkout-order-total-button-button']"));
        IWebElement btnPay => driver.FindElement(By.XPath("//div[text()='Proceed to Pay']"));
        
        IWebDriver driver;
        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void proceedToCheckout()
        {
            cartBtn.Click();
            Thread.Sleep(1000);
            btnSelect.Click();
            Thread.Sleep(1000);
            btnCheckout.Click();
            Thread.Sleep(1000);
            btnPay.Click();
            Thread.Sleep(5000);
        }
    }
}
