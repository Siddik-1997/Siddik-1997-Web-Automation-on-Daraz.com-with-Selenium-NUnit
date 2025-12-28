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
        IWebElement btnCross => driver.FindElement(By.XPath("//i[@class='next-icon next-icon-close next-icon-small']"));
       
        IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void selectProductCategory()
        {
            categoryOne.Click();
            Thread.Sleep(1000);
            selectFirstItem.Click();
            Thread.Sleep(1000);
            btnAddtoCart.Click();
            Thread.Sleep(2000);

        }

        public void selectDifferentProductCategory()
        {
            driver.Navigate().GoToUrl("https://www.daraz.com.bd/#hp-categories");
            Thread.Sleep(1000);
            categoryTwo.Click();
            Thread.Sleep(1000);
            selectFirstItem.Click();
            Thread.Sleep(1000);
            btnAddtoCart.Click();
            Thread.Sleep(1000);
            btnCross.Click();
            Thread.Sleep(2000);

        }

    }
}
