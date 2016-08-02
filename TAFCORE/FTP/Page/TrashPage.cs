using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Elements;
using TAFCORE.Page;
using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;


namespace FTP.Page
{
    public class TrashPage
    {
        protected static string MAIL_TRASH = "https://mail.google.com/mail/u/0/#trash";
        public Link Letter { get; set; }
        public Button ButtonDelete { get; private set; } = new Button(By.XPath("//div[text()='Delete forever']"));

        public TrashPage()
        {
            Driver.DriverInstance.Navigate().GoToUrl(MAIL_TRASH);
            //ButtonDelete = new Button();
            //ButtonDelete.by = (By.XPath("//div[text()='Delete forever']"));
        }



        public bool CheckLetter(string email, string str)
        {

            string text;
            try
            {
                Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}'] and td[6]/div/div/div/span[1][.='{str}']]"));
                Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[7]/img"));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
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
