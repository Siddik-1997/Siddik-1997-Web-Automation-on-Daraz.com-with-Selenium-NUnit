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
        IWebElement cartBtn => driver.FindElement(By.XPath("//span[@class='cart-icon-daraz']"));
        IWebElement btnSelect => driver.FindElement(By.XPath("//div[@id='listHeader_H']//label[contains(@class,'list-header-checkbox')]"));
        IWebElement btnCheckout => driver.FindElement(By.XPath("//button[@class='next-btn next-btn-primary next-btn-large checkout-order-total-button automation-checkout-order-total-button-button']"));
        IWebElement btnPay => driver.FindElement(By.XPath("//div[text()='Proceed to Pay']"));
        IWebElement mainTitle => driver.FindElement(By.XPath("//h2[@class='main-title']"));

        IWebDriver driver;
        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void proceedToCheckout()
        {
            cartBtn.Click();
            btnSelect.Click();
            btnCheckout.Click();
            Thread.Sleep(1000);

        }

        public void proccedtoPay()
        {
            btnPay.Click();
            Thread.Sleep(1000);
        }

        public void assertCheckoutPage()
        {
            string actualTitle = mainTitle.Text.Trim();
            string expectedTitle = "Select Payment Method";
            Assert.AreEqual(expectedTitle, actualTitle);

        }
    }
}
