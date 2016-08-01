using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;
using TAFCORE.Utility.WebDriver;
using System.Threading;
using OpenQA.Selenium;
using TAFCORE.Utility.Attachment;

namespace FTP.Steps
{
    public class InBoxPageStep : Step
    {
        protected static string MAIL_SPAM = "https://mail.google.com/mail/u/0/#spam";
        protected static string MAIL_SETTING = "https://mail.google.com/mail/#settings/";


        public static void SendMassage(string name, string title, string text)
        {
            InBoxPage inp = new InBoxPage();
            inp.buttonCompose.Click();
            inp.tbRecipient.ClearAndType(name);
            inp.tbSubject.ClearAndType(title);
            inp.tbText.ClearAndType(text);
            inp.buttonSend.Click();


        }

        public static void SendMassageWithAttach(string name, string title, string text, string path)
        {
            InBoxPage inp = new InBoxPage();
            inp.buttonCompose.Click();
            inp.tbRecipient.ClearAndType(name);
            inp.tbSubject.ClearAndType(title);
            inp.tbText.ClearAndType(text);
            inp.buttonAttach.Click();
            Attachment.AttachFile(path);
            inp.buttonSend.Click();

        }

        public static void SignOutAccount()
        {

            InBoxPage inp = new InBoxPage();
            inp.buttonIcon.Click();
            Thread.Sleep(1000);
            inp.buttonSignOut.Click();

            try
            {
                IAlert alert = Driver.DriverInstance.SwitchTo().Alert();
                alert.Accept();

            }
            catch (NoAlertPresentException e)
            {
            }
            catch (NoSuchElementException e)
            {
            }

        }

        public static void MoveMailIntoSpam(string email)

        {
            InBoxPage inp = new InBoxPage();
            inp.ClickCheckBoxInLetter(email);
            inp.buttonSpam.Click();

        }

        public static void GoToSpam()
        {
            Driver.DriverInstance.Navigate().GoToUrl(MAIL_SPAM);
        }

        public static bool CheckLetter(string email, string text)
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

        public static bool AlertIsPresent()
        {
            InBoxPage inp = new InBoxPage();
            return Driver.DriverInstance.IsElementPresent(inp.lableAlertBigFile.by);
        }
    }
}
