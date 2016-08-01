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
        public Link letter;

        public TrashPage()
        {
            Driver.DriverInstance.Navigate().GoToUrl(MAIL_TRASH);
        }



        public bool CheckLetter(string email, string str)
        {

            string text;
            try
            {
                text = Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[6]/div/div/div/span[1]")).Text;
                Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[7]/img"));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return text.Equals(str);
        }

    }
}
