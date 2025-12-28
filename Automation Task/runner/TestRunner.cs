using Automation_Task.pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Task.runner
{
    public class TestRunner:SetupPage
    {
        HomePage homePage;
        SignupPage signupPage;
        LoginPage loginPage;
        ProductPage productPage;
        CheckoutPage checkoutPage;

        [Test, Order(1)]
        public void changeLanguage()
        {   
            homePage = new HomePage(driver);
            // Change the default Language English to Bangla
            homePage.languageMenuClicked();
            homePage.assertSiteLanguage("ফ্ল্যাশ সেল");

            // Back to the default language English from Bangla
            homePage.languageMenuClicked();
            homePage.assertSiteLanguage("Flash Sale");

        }
        //[Test, Order(2)]
        public void signup() {
            signupPage = new SignupPage(driver);
            signupPage.doSignup("01993493888");
        }

        [Test, Order(3)]
        public void login()
        {
           loginPage = new LoginPage(driver);
            loginPage.doLogin("abubakkar1045@gmail.com", "Siddik@1234");
            Thread.Sleep(5000);
            loginPage.loginAssertion();
        }

        [Test, Order(4)]
        public void productCategory()
        {
            productPage = new ProductPage(driver);
            productPage.selectProductCategory();
            productPage.selectDifferentProductCategory();
        }

        [Test, Order(5)]
        public void checkoutProcess()
        {
            checkoutPage = new CheckoutPage(driver);
            checkoutPage.proceedToCheckout();
        }

    }
}
