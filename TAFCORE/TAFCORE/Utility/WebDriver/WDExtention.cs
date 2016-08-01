using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace TAFCORE.Utility.WebDriver
{
    public static class WDExtention
    {

        public static bool IsElementPresent(this IWebDriver driver, By by)
        {
            try
            {
                try
                {
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    // Console.WriteLine($"Present { driver.IsElementPresent(by)},{driver.FindElement(by).}");
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException ex)
                {
                    return false;
                }
                catch (UnhandledAlertException e)
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    alert.Accept();
                    IsElementPresent(driver, by);
                    return false;
                }
            }
            catch (NoAlertPresentException e)
            {
                IsElementPresent(driver, by);
                return false;
            }
        }
    }
}
