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
        private static string MAIL_INBOX = "https://mail.google.com/mail/u/0/#inbox";


        public static void SendMassage(string name, string title, string text)
        {
            InBoxPage inp = new InBoxPage();
            inp.ButtonCompose.Click();
            inp.TbRecipient.ClearAndType(name);
            inp.TbSubject.ClearAndType(title);
            inp.TbText.ClearAndType(text);
            inp.ButtonSend.Click();


        }
        public static void GoToInBoxPage()
        {
            Driver.DriverInstance.Navigate().GoToUrl(MAIL_INBOX);
        }

        public static void SendMassageWithAttach(string name, string title, string text, string path)
        {
            InBoxPage inp = new InBoxPage();
            inp.ButtonCompose.Click();
            inp.TbRecipient.ClearAndType(name);
            inp.TbSubject.ClearAndType(title);
            inp.TbText.ClearAndType(text);
            inp.ButtonAttach.Click();
            Attachment.AttachFile(path);
            inp.ButtonSend.Click();

        }

        public static void SignOutAccount()
        {

            InBoxPage inp = new InBoxPage();
            inp.ButtonIcon.Click();
            Thread.Sleep(1000);
            inp.ButtonSignOut.Click();

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
            inp.ButtonSpam.Click();

        }



        public static void MoveMailFromSpam(string email)
        {
            InBoxPage inp = new InBoxPage();
            if (inp.SelectAllMail() == true)
                inp.ButtonNotSpam.Click();
            else return;
        }

        public static void DeleteAllMail()
        {
            Thread.Sleep(3000);
            Driver.DriverInstance.Navigate().GoToUrl(MAIL_INBOX);
            Thread.Sleep(3000);
            InBoxPage inp = new InBoxPage();
            if (inp.SelectAllMail())
                inp.ButtonDelete.Click();
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
            return Driver.DriverInstance.IsElementPresent(inp.LableAlertBigFile.by);
        }

        public static void CancelAlert()
        {
            InBoxPage inp = new InBoxPage();
            inp.ButtonCancel.Click();
        }

        public static string GetSignature()
        {
            InBoxPage inp = new InBoxPage();
            inp.ButtonCompose.Click();
            Thread.Sleep(4000);
            return inp.TbSignature.GetText();
        }

        public static void CloseFormForMail()
        {
            InBoxPage inp = new InBoxPage();
            inp.ButtonClose.Click();
        }
        public static void AddEmoticons(string name, string title)
        {
            InBoxPage inp = new InBoxPage();
            inp.ButtonCompose.Click();
            inp.TbRecipient.ClearAndType(name);
            inp.TbSubject.ClearAndType(title);
            inp.ButtonEmoticons.Click();
        }

        public static bool EmoticonsIsPresent()
        {
            InBoxPage inp = new InBoxPage();
            return Driver.DriverInstance.IsElementPresent(inp.LabelEmoticons.by);
        }

        public static bool EmoticonsIsPresentInMail()
        {
            InBoxPage inp = new InBoxPage();
            return Driver.DriverInstance.IsElementPresent(inp.LanelIcon.by);
        }

        public static void ChooseEmotionsIcons(int count)

        {
            InBoxPage inp = new InBoxPage();
            inp.ChooseEmotionsIcons(count);
            inp.ButtonSend.Click();
        }

    }
}
