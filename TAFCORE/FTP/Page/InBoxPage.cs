using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Elements;
using TAFCORE.Page;
using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;
using TAFCORE.Utility.Randomizer;
using System.Threading;

namespace FTP.Page
{
    class InBoxPage : BasePage
    {
        public Button ButtonCompose { get;  private set;} = new Button(By.XPath("//div[@gh='cm']"));
        public TextBox TbRecipient { get; private set; } = new TextBox(By.XPath("//textarea[@name='to']"));
        public TextBox TbSubject { get; private set; } = new TextBox(By.Name("subjectbox"));
        public TextBox TbText { get; private set; } = new TextBox(By.XPath("//div[@role='textbox']"));
        public Button ButtonSend { get; private set; } = new Button(By.XPath("//div[@class='T-I J-J5-Ji aoO T-I-atl L3']"));
        public Button ButtonIcon { get; private set; } = new Button(By.XPath("//span[@class='gb_3a gbii']"));
        public Button ButtonSignOut { get; private set; } = new Button(By.XPath("//a[contains(.,'Sign out')]"));
        public CheckBox ChBox { get; set; } 
        public Button ButtonSpam { get; private set; } = new Button(By.XPath("//div[@class='asl T-I-J3 J-J5-Ji']"));
        public Button ButtonNotSpam { get; private set; } = new Button(By.XPath("//div[text()='Not spam']"));
        public Button ButtonDelete { get; private set; } = new Button(By.XPath("//div[@class='ar9 T-I-J3 J-J5-Ji']"));
        public Link Letter { get; set; } 
        public Button ButtonAttach { get; private set; } = new Button(By.XPath("//div[@aria-label='Attach files']"));
        public Label LableAlertBigFile { get; private set; } = new Label(By.XPath("//div[@class='Kj-JD-K7 Kj-JD-K7-GIHV4']"));
        public Button ButtonCancel { get; private set; } = new Button(By.XPath("//button[@name='cancel']"));
        public TextBox TbSignature { get; private set; } = new TextBox(By.XPath("//div[@class='gmail_signature']/div"));
        public Button ButtonClose { get; private set; } = new Button(By.XPath("//img[@alt='Close']"));
        public Button ButtonEmoticons { get; private set; } = new Button(By.XPath("//div[@aria-label='Insert emoticon ‪(Ctrl-Shift-2)‬']"));
        public Label LabelEmoticons { get; private set; } = new Label(By.XPath("//div[@class='a8u']"));
        public Label LanelIcon { get; private set; } = new Label(By.XPath("//img[@class='CToWUd']"));

        public InBoxPage()
        {
            //ButtonCompose = new Button();
            //ButtonCompose.by = (By.XPath("//div[@gh='cm']"));
            //TbRecipient = new TextBox();
            //TbRecipient.by = (By.XPath("//textarea[@name='to']"));
            //TbSubject = new TextBox();
            //TbSubject.by = (By.Name("subjectbox"));
            //TbText = new TextBox();
            //TbText.by = (By.XPath("//div[@role='textbox']"));
            //ButtonSend = new Button();
            //ButtonSend.by = (By.XPath("//div[@class='T-I J-J5-Ji aoO T-I-atl L3']"));
            //ButtonIcon = new Button();
            //ButtonIcon.by = (By.XPath("//span[@class='gb_3a gbii']"));
            //ButtonSignOut = new Button();
            //ButtonSignOut.by = (By.XPath("//a[contains(.,'Sign out')]"));
            //ButtonAttach = new Button();
            //ButtonAttach.by = (By.XPath("//div[@aria-label='Attach files']"));
            //ButtonSpam = new Button();
            //ButtonSpam.by = (By.XPath("//div[@class='asl T-I-J3 J-J5-Ji']"));
            //ButtonNotSpam = new Button();
            //ButtonNotSpam.by = (By.XPath("//div[text()='Not spam']"));
            //LableAlertBigFile = new Label();
            //LableAlertBigFile.by = (By.XPath("//div[@class='Kj-JD-K7 Kj-JD-K7-GIHV4']"));
            //ButtonDelete = new Button();
            //ButtonDelete.by = (By.XPath("//div[@class='ar9 T-I-J3 J-J5-Ji']"));
            //ButtonCancel = new Button();
            //ButtonCancel.by = (By.XPath("//button[@name='cancel']"));
            //TbSignature = new TextBox();
            //TbSignature.by = (By.XPath("//div[@class='gmail_signature']/div"));
            //ButtonClose = new Button();
            //ButtonClose.by = (By.XPath("//img[@alt='Close']"));
            //ButtonEmoticons = new Button();
            //ButtonEmoticons.by = (By.XPath("//div[@aria-label='Insert emoticon ‪(Ctrl-Shift-2)‬']"));
            //LabelEmoticons = new Label();
            //LabelEmoticons.by = (By.XPath("//div[@class='a8u']"));
            //LanelIcon = new Label();
            //LanelIcon.by = (By.XPath("//img[@class='CToWUd']"));
        }


        public bool SelectAllMail()
        {
            if (Driver.DriverInstance.FindElements(By.XPath("//tr[td[4]/div[2]/span[@email]]/td[2]/div[@role='checkbox']")).Count == 0)
                return false;
            foreach (var el in Driver.DriverInstance.FindElements(By.XPath("//tr[td[4]/div[2]/span[@email]]/td[2]/div[@role='checkbox']")))
            {
                if (!el.Selected)
                {
                    el.Click();
                }
                
            }
            return true;
        }

        public void ClickCheckBoxInLetter(string email)
        {

            ChBox = new CheckBox();
            ChBox.by = (By.XPath($"//tr[td[4]/div[2]/span[@email='{email}']]/td[2]/div[@role='checkbox']"));
            
          
            ChBox.Select();
        }

        public void ChooseLetter(string email)
        {

            Letter = new Link();
            //letter.by = (By.XPath($"//tr/td[4]/div[2]/span[@email='{email}']"));
           Letter.by = (By.XPath($"//span[@email='{email}']"));

            Letter.Click();
        }



        public bool CheckLetter(string email, string str)
        {
            
            try
            {
                Driver.DriverInstance.FindElement(By.XPath($"//tr[td[4]/div[2]/span[@email='{email}'] and td[6]/div/div/div/span[1][.='{str}']]"));

            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
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

        public List<string> ChooseEmotionsIcons(int count)
        {
            Button buttonAllEmoticons = new Button();
            buttonAllEmoticons.by = (By.XPath("//button[@title='Show face emoticons']"));
            buttonAllEmoticons.Click();
            List<string> listSeningEmotions = new List<string>();

            string iconStringNumber;
            for (int i = 0; i < count; i++)
            {
                iconStringNumber = RandomUntil.generateIconNumber();
                listSeningEmotions.Add(iconStringNumber);
                Button button = new Button();
                button.by =  (By.XPath(string.Format($"//button[@string='{iconStringNumber}']")));
                button.Click();
            }
            return listSeningEmotions;

        }


    }
}
