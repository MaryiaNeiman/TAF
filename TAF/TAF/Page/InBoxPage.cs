using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTAF.Elements;
using CoreTAF.Page;
using OpenQA.Selenium;
using CoreTAF.Utility.WebDriver;
using TAF.Extention;
using OpenQA.Selenium.Support.UI;
namespace TAF.Page
{
    class InBoxPage : BasePage
    {
        Button buttonCompose;
        TextBox tbRecipient;
        TextBox tbSubject;
        TextBox tbText;
        Button buttonSend;
        Button buttonIcon;
        Button buttonSignOut;
        CheckBox chBox;
        Button buttonSpam;
        Button buttonSettings;
        Link linkSettings;
        Link letter;
        Button buttonAttach;

        public InBoxPage()
        {
            buttonCompose = new Button();
            buttonCompose.by = (By.XPath("//div[@gh='cm']"));
            tbRecipient = new TextBox();
            tbRecipient.by = (By.XPath("//textarea[@name='to']"));
            tbSubject = new TextBox();
            tbSubject.by = (By.Name("subjectbox"));
            tbText = new TextBox();
            tbText.by = (By.XPath("//div[@role='textbox']"));
            buttonSend = new Button();
            buttonSend.by = (By.XPath("//div[@class='T-I J-J5-Ji aoO T-I-atl L3']"));
            buttonIcon = new Button();
            buttonIcon.by = (By.XPath("//span[@class='gb_3a gbii']"));
            buttonSignOut = new Button();
            buttonSignOut.by = (By.XPath("//a[contains(.,'Sign out')]"));
            buttonAttach = new Button();
            buttonAttach.by = (By.XPath("//div[@class='a1 aaA aMZ']"));

        }

        public void ClickOnCompose()
        {
            Driver.DriverInstance.WaitUntilVisible(buttonCompose.by);
            buttonCompose.Click();
        }

        public void SetTbRecipient(string str)
        {
            Driver.DriverInstance.WaitUntilVisible(tbRecipient.by);
            tbRecipient.ClearAndType(str);
        }

        public void SetTbSubject(string str)
        {
            tbSubject.ClearAndType(str);
        }

        public void SetTbText(string str)
        {
            tbText.ClearAndType(str);
        }
        public void ClickButtonSend()
        {
            buttonSend.Click();
        }

        public void ClickOnIcon()
        {
            Driver.DriverInstance.WaitUntilVisible(buttonIcon.by);
            Driver.DriverInstance.WaitUntilClickable(buttonIcon.by);
            buttonIcon.Click();
        }

        public void ClickOnSignOut()
        {
            System.Threading.Thread.Sleep(1000);
            Driver.DriverInstance.WaitUntilVisible(buttonSignOut.by);
            buttonSignOut.Click();
           

        }

        public void ClickCheckBoxInLetter(string email)
        {
            Driver.DriverInstance.WaitUntilVisible(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[2]/div[@role='checkbox']"));
            chBox = new CheckBox();
            chBox.by = (By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[2]/div[@role='checkbox']"));

            chBox.Click();
        }

        public void ChooseLetter(string email)
        {
            Driver.DriverInstance.WaitUntilVisible(By.XPath($"//tr/td[4]/div[2]/span[@email='{email}']"));
            letter = new Link();
            letter.by = (By.XPath($"//tr/td[4]/div[2]/span[@email='{email}']"));
            letter.Click();
        }

        public void ClickOnSpam()
        {
            buttonSpam = new Button();
            buttonSpam.by = (By.XPath("//div[@class='asl T-I-J3 J-J5-Ji']"));
            //Driver.DriverInstance.WaitUntilVisible(letter.by);
            buttonSpam.Click();
        }

        public bool CheckLetter(string email, string str)
        {
            Driver.DriverInstance.WaitUntilVisible(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[6]/div/div/div/span[1]"));
            string text;
            try
            {
                text = Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[6]/div/div/div/span[1]")).Text;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return text.Equals(str);
        }

        //public void ClickButtonSettings()
        //{
        //    buttonSettings = new Button();
        //    buttonSettings.by = (By.XPath("//div[@class='Cr aqJ']/div[@class='G-Ni J-J5-Ji']/div"));
        //    Driver.DriverInstance.WaitUntilVisible(buttonSettings.by);
        //    buttonSettings.Click();
        //}

        //public void ClickOnLinkSettings()
        //{
        //    linkSettings = new Link();
        //    linkSettings.by = (By.XPath("//div[@id='ms']/div"));
        //    Driver.DriverInstance.WaitUntilVisible(linkSettings.by);
        //    Driver.DriverInstance.WaitUntilClickable(linkSettings.by);
        //    WebDriverWait wait = new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(60));
        //    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(linkSettings.by));

        //    linkSettings.Click();
        //}

        //public void ClickSetting()
        //{

        //    var elements = Driver.DriverInstance.FindElements((By.XPath("//div[@class='Cr aqJ']/div[@class='G-Ni J-J5-Ji']/div")));
        //    foreach (Element element in elements)
        //    {
        //        if (element.isDisplayed())
        //        {
        //            element.Click();
        //            System.Threading.Thread.Sleep(1000);
        //            Driver.DriverInstance.FindElement(By.XPath("//*[@id='ms']")).Click();
        //            System.Threading.Thread.Sleep(1000);
        //        }
        //    }
        //}

        public void ClickOnAttachFile()
        {
            buttonAttach.Click();
        }
    }
}
