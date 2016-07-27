using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Page;
using CoreTAF.Utility.WebDriver;
using AutoItX3Lib;
using System.Threading;
using OpenQA.Selenium;
using CoreTAF.Utility.Attachment;

namespace TAF.Steps
{
   public class InBoxPageStep : Step
    {
        protected static string MAIL_SPAM = "https://mail.google.com/mail/u/0/#spam";
        protected static string MAIL_SETTING = "https://mail.google.com/mail/#settings/";
        public static void SendMassage(string name, string title, string text)
        {
            InBoxPage inp = new InBoxPage();
            inp.ClickOnCompose();
            inp.SetTbRecipient(name);
            inp.SetTbSubject(title);
            inp.SetTbText(text);
            inp.ClickButtonSend();
          
        }

        public static void SendMassageWithAttach(string name, string title, string text, string path)
        {
            InBoxPage inp = new InBoxPage();
            inp.ClickOnCompose();
            inp.SetTbRecipient(name);
            inp.SetTbSubject(title);
            inp.SetTbText(text);
            inp.ClickOnAttachFile();
            Attachment.AttachFile(path);
            inp.ClickButtonSend();

        }

        public static void SignOutAccount()
        {
            
            InBoxPage inp = new InBoxPage();
            inp.ClickOnIcon();
            inp.ClickOnSignOut();

            try
            {
                IAlert alert = Driver.DriverInstance.SwitchTo().Alert();
                alert.Accept();
               
            }
            catch (NoAlertPresentException e) {
            }
            catch (NoSuchElementException e) {
            }

        }

        public static void MoveMailIntoSpam(string email)

        {
            InBoxPage inp = new InBoxPage();
            inp.ClickCheckBoxInLetter(email);
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

        public static void ChooseSettings()
        {
            InBoxPage inp = new InBoxPage();
            //inp.ClickButtonSettings();
            //inp.ClickOnLinkSettings();
            //inp.ClickSetting();
           Driver.DriverInstance.Navigate().GoToUrl(MAIL_SETTING);
        }

        public static void ClickOnLinkInMail(string email)
        {
            InBoxPage inp = new InBoxPage();
            inp.ChooseLetter(email);
        }
    }
}
