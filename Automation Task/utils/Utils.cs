using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Task.utils
{
    public class Utils
    {
        public static void WaitForElement(IWebDriver driver, By locator, int timeInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeInSeconds));
            wait.Until(drv => drv.FindElement(locator).Displayed);
        }

    }
}
