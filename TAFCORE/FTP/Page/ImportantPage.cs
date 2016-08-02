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
        public Link Letter { get; private set; } 
        public TextBox Search { get; private set; } = new TextBox(By.XPath("//h2[text()='Search']/../descendant::input"));
        public Button ButtonSearch { get; private set; } = new Button(By.XPath("//button[@aria-label='Search Gmail']"));
        public Button ButtonDelete { get; private set; } = new Button(By.XPath("//div[text()='Delete forever']"));

        public ImportantPage()
        {
            //Driver.DriverInstance.Navigate().GoToUrl(MAIL_IMP);
            //Search = new TextBox();
            //Search.by = (By.XPath("//h2[text()='Search']/../descendant::input"));
            Search.ClearAndType("is:important");

            //Search.by = (By.XPath("//h2[text()='Search']/../descendant::input"));
            //ButtonSearch = new Button();
            //ButtonSearch.by = (By.XPath("//button[@aria-label='Search Gmail']"));
            ButtonSearch.Click();

            //ButtonDelete = new Button();
            //ButtonDelete.by = (By.XPath("//div[text()='Delete forever']"));

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

        public void SelectAllMail()
        {
            foreach (var el in Driver.DriverInstance.FindElements(By.XPath("//tr[td[4]/div[2]/span[@email]]/td[2]/div[@role='checkbox']")))
            {
                if (!el.Selected)
                {
                    el.Click();
                }
            }
        }
    }
}
