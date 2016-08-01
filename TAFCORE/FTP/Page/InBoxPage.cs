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
    class InBoxPage : BasePage
    {
        public Button buttonCompose;
        public TextBox tbRecipient;
        public TextBox tbSubject;
        public TextBox tbText;
        public Button buttonSend;
        public Button buttonIcon;
        public Button buttonSignOut;
        public CheckBox chBox;
        public Button buttonSpam;
        public Button buttonSettings;
        public Link linkSettings;
        public Link letter;
        public Button buttonAttach;
        public Label lableAlertBigFile;

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
            buttonSpam = new Button();
            buttonSpam.by = (By.XPath("//div[@class='asl T-I-J3 J-J5-Ji']"));
            lableAlertBigFile = new Label();
            lableAlertBigFile.by = (By.XPath("//div[@class='Kj-JD-K7 Kj-JD-K7-GIHV4']"));
        }



        public void ClickCheckBoxInLetter(string email)
        {

            chBox = new CheckBox();
            chBox.by = (By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[2]/div[@role='checkbox']"));

            chBox.Select();
        }

        public void ChooseLetter(string email)
        {

            letter = new Link();
            letter.by = (By.XPath($"//tr/td[4]/div[2]/span[@email='{email}']"));
            letter.Click();
        }



        public bool CheckLetter(string email, string str)
        {

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

      


    }
}
