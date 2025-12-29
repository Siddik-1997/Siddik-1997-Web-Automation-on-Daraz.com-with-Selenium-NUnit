using Automation_Task.testData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Text.Json;
using System.IO;

namespace Automation_Task.utils
{
    public class Utils
    {
        public static void WaitForElement(
            IWebDriver driver,
            IWebElement element,
            int timeInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeInSeconds));
            wait.Until(d => element.Displayed);
        }

        public static Automation_Task.testData.LoginData ReadLoginData(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Automation_Task.testData.LoginData>(json);
        }

    }
}
