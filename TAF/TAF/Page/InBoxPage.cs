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
        Button buttonSingOut;
        Href chBox;
        Button buttonSpam;

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
            buttonSend.by = (By.XPath("/html/body/div[14]/div/div/div/div[1]/div[3]/div[1]/div[1]/div/div/div/div[3]/div/div/div[4]/table/tbody/tr/td[2]/table/tbody/tr[2]/td/div/div/div[4]/table/tbody/tr/td[1]/div/div[2]"));
            buttonIcon = new Button();
            buttonIcon.by = (By.XPath("//span[@class='gb_3a gbii']"));
            buttonSingOut = new Button();
            buttonSingOut.by = (By.XPath("//a[contains(.,'Sign out')]"));
           
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
            buttonIcon.Click();
        }

        public void ClickOnSignOut()
        {
            System.Threading.Thread.Sleep(1000);
            //Driver.DriverInstance.WaitUntilVisible(buttonSingOut.by);           
            buttonSingOut.Click();
           
        }

        public void ChooseLetter(string email)
        {
            Driver.DriverInstance.WaitUntilVisible(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[2]/div[@role='checkbox']"));
            chBox = new Href();
            chBox.by = (By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[2]/div[@role='checkbox']"));
          
            chBox.Click();
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

    }
}
