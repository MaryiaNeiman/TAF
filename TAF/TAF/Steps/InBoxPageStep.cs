using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Page;
using CoreTAF.Utility.WebDriver;
namespace TAF.Steps
{
   public class InBoxPageStep
    {
        protected static string MAIL_SPAM = "https://mail.google.com/mail/u/0/#spam";
        public static void SendMassage(string name, string title, string text)
        {
            InBoxPage inp = new InBoxPage();
            inp.ClickOnCompose();
            inp.SetTbRecipient(name);
            inp.SetTbSubject(title);
            inp.SetTbText(text);
            inp.ClickButtonSend();
            //inp.ClosePage();
        }

        public static void SignOutAccount()
        {
            
            InBoxPage inp = new InBoxPage();
            inp.ClickOnIcon();
            inp.ClickOnSignOut();

        }

        public static void SelectLetter(string email)

        {
            InBoxPage inp = new InBoxPage();
            inp.ChooseLetter(email);
            inp.ClickOnSpam();
        }

        public static void GoToSpam()
        {
            Driver.DriverInstance.Navigate().GoToUrl(MAIL_SPAM);
        }

        public static bool CheckLetter(string email,string text)
        {
            InBoxPage inp = new InBoxPage();
           return inp.CheckLetter(email, text);
        }
    }
}
