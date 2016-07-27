using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CoreTAF.Utility.WebDriver;
namespace CoreTAF.Page
{

    public abstract class BasePage
    {

        protected string url;
        protected String pageTitle;


        protected BasePage(string url)
        {
            this.url = url;
        }
        protected BasePage()
        {
          
        }

        public void GoToPage()
        {
            //Driver.DriverInstance.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            Driver.DriverInstance.Navigate().GoToUrl(url);
        }

        protected string formatLogMsg(string message)
        {
            return message;
        }

        public static void ClosePage()
        {
            Driver.DriverInstance.Close();
        }


       

    }
}
