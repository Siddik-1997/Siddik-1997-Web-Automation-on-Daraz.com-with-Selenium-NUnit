using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Task.pages
{
    public class ProductPage
    {
        IWebElement categoryOne => driver.FindElement(By.XPath("(//a[contains(@class,'card-categories-li')])[1]"));
        IWebElement selectFirstItem => driver.FindElement(By.XPath("(//div[@data-qa-locator='general-products']//div[@data-qa-locator='product-item'])[1]"));  
        IWebElement categoryTwo => driver.FindElement(By.XPath("(//a[contains(@class,'card-categories-li')])[2]"));
        IWebElement btnAddtoCart => driver.FindElement(By.XPath("//button[contains(@class,'add-to-cart-buy-now-btn')][2]"));
        IWebElement CartMessage => driver.FindElement(By.XPath("//span[@class='cart-message-text']"));
        IWebElement btnCross => driver.FindElement(By.XPath("//i[@class='next-icon next-icon-close next-icon-small']"));    
       
        IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void selectProductCategory()
        {
            categoryOne.Click();
            selectFirstItem.Click();
            btnAddtoCart.Click();
            Thread.Sleep(2000);
            btnCross.Click();

        }

        public void selectDifferentProductCategory()
        {
            driver.Navigate().GoToUrl("https://www.daraz.com.bd/#hp-categories");
            categoryTwo.Click();
            selectFirstItem.Click();
            btnAddtoCart.Click();
            Thread.Sleep(1000);
            btnCross.Click();
        }

        public void productAddedAssertion()
        {
            string actualCartMessage = CartMessage.Text.Trim();
            string expectedCartMessage = "Added to cart successfully!";
            Assert.AreEqual(actualCartMessage, expectedCartMessage);
        }

    }
}
