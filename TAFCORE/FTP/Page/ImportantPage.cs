using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Elements;
using TAFCORE.Utility.WebDriver;
using OpenQA.Selenium;

namespace FTP.Page
{
    class ImportantPage
    {
        protected static string MAIL_IMP = "https://mail.google.com/mail/u/0/#imp";
        public Link letter;
        public TextBox search;
        public Button buttonSearch;

        public ImportantPage()
        {
            //Driver.DriverInstance.Navigate().GoToUrl(MAIL_IMP);
            search = new TextBox();
            search.by = (By.XPath("//h2[text()='Search']/../descendant::input"));
            search.ClearAndType("is:important");
            search.by = (By.XPath("//h2[text()='Search']/../descendant::input"));
            buttonSearch = new Button();
            buttonSearch.by = (By.XPath("//button[@aria-label='Search Gmail']"));
            buttonSearch.Click();

        }



        public bool CheckLetter(string email, string str, string str2)
        {

            string text;
            bool flag = true;
            try
            {
                Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}'] and /td[6]/div/div/div/span[1][text()='{str}']"));


            }
            catch (NoSuchElementException)
            {
                flag = false;
            }

            try
            {
                if (flag)
                {
                    Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}'] and /td[6]/div/div/div/span[1][text()='{str2}']"));
                    return false;
                }

            }
            catch (NoSuchElementException)
            {
                return true;
            }
            return false;
        }
    }
}
