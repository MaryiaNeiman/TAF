using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Elements;
using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;
namespace FTP.Page
{
    class ThemesPage
    {
        public Link LinkSetThemes { get; private set; } = new Link(By.XPath("//a[contains(text(),'Set Theme')]"));
        public Button ButtonMyPhoto { get; private set; } = new Button(By.XPath("//div[text()='My Photos']"));
        public Button ButtonUploadPhoto { get; private set; } = new Button(By.XPath("//div[text()='Upload a photo']"));
        public Button ButtonSelectedPhotoFromComputer { get; private set; } = new Button(By.XPath("//div[text()='Select a photo from your computer']"));
        public Label LabelMessage { get; private set; } = new Label(By.XPath("//span[contains(text(),'There was an upload error.')]"));
        public Button ButtonClose { get; private set; } = new Button(By.XPath("//div[@aria-label='Close']"));
        public Button ButtonClose2 { get; private set; } = new Button(By.XPath("//span[@aria-label='Close']"));

        public ThemesPage()
        {
            //LinkSetThemes = new Link();
            //LinkSetThemes.by = (By.XPath("//a[contains(text(),'Set Theme')]"));           
            //ButtonMyPhoto = new Button();
            //ButtonMyPhoto.by = (By.XPath("//div[text()='My Photos']"));
            //ButtonUploadPhoto = new Button();
            //ButtonUploadPhoto.by = (By.XPath("//div[text()='Upload a photo']"));
            //ButtonSelectedPhotoFromComputer = new Button();
            //ButtonSelectedPhotoFromComputer.by = (By.XPath("//div[text()='Select a photo from your computer']"));
            //LabelMessage = new Label();
            //LabelMessage.by = (By.XPath("//span[contains(text(),'There was an upload error.')]"));
            //ButtonClose = new Button();
            //ButtonClose.by = (By.XPath("//div[@aria-label='Close']"));
            //ButtonClose2 = new Button();
            //ButtonClose2.by = (By.XPath("//span[@aria-label='Close']"));

        }

        public void ChangeWindow()
        {
            Driver.DriverInstance.SwitchTo().Frame(Driver.DriverInstance.FindElement(By.XPath("//iframe[@class='KA-JQ']")));
            
        }

        public void GoToFirstWindow()
        {
            Driver.DriverInstance.SwitchTo().DefaultContent();
        }
    }
}
