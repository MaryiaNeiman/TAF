using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace CoreTAF.Utility.WebDriver
{
    public class Driver
    {
        private static IWebDriver driverInstance = CreateDriver();

        

        private Driver()
        {
        }

        public static IWebDriver DriverInstance
        {
            get
            {
              return driverInstance;
            }
        }


        //public static void Close()
        //{
        //    if (driverInstance != null)
        //    {
        //        driverInstance.Quit();
        //        driverInstance = null;
        //    }
        //}

        private static IWebDriver CreateDriver()
        {
            string _browser = ConfigurationManager.AppSettings["Browser"];

            switch (_browser)
            {
                case "FireFox":
                    return new FirefoxDriver();
                case "Chrome":
                    return new ChromeDriver();
                default:
                    return new FirefoxDriver();
            }
        }
    }

   
}
