using OpenQA.Selenium;

namespace Automation_Task.pages
{
    public class HomePage
    {

        IWebElement languageMenu => driver.FindElement(By.XPath("//div[@class=\"top-links-item white\"][3]"));
        IWebElement langugageMenuText => driver.FindElement(By.XPath("//div[@id='topActionSwitchLang']/span"));
        IWebElement titleText => driver.FindElement(By.XPath("//p[@class=\"hp-mod-card-title one-line-clamp\"]"));
        IWebElement selectBangla => driver.FindElement(By.XPath("//div[@data-lang=\"bn\"]"));
        IWebElement selectEnglish => driver.FindElement(By.XPath("//div[@data-lang=\"en\"]"));

        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void languageMenuClicked()
        {
            languageMenu.Click();
            Thread.Sleep(1000);
            string getLanText = langugageMenuText.Text;
            if (!getLanText.Trim().Equals("change language", StringComparison.OrdinalIgnoreCase))
            {
                selectBangla.Click();
            }
            else
            {
                selectEnglish.Click();
            }

            Thread.Sleep(1000);
        }

        public void assertSiteLanguage(string expectedTitleText)
        {
            string actualTitleText = titleText.Text.Trim();
            Assert.AreEqual(expectedTitleText, actualTitleText,
                "Site language title does not match!");
        }
    }
}
