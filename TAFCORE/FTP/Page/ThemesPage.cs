﻿using System;
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
        public Link linkSetThemes;
        public Button buttonMyPhoto;
        public Button buttonUploadPhoto;
        public Button buttonSelectedPhotoFromComputer;
        public Label labelMessage;

            public ThemesPage()
        {
            linkSetThemes = new Link();
            linkSetThemes.by = (By.XPath("//a[contains(text(),'Set Theme')]"));           
            buttonMyPhoto = new Button();
            buttonMyPhoto.by = (By.XPath("//div[text()='My Photos']"));
            buttonUploadPhoto = new Button();
            buttonUploadPhoto.by = (By.XPath("//div[text()='Upload a photo']"));
            buttonSelectedPhotoFromComputer = new Button();
            buttonSelectedPhotoFromComputer.by = (By.XPath("//div[text()='Select a photo from your computer']"));
            labelMessage = new Label();
            labelMessage.by = (By.XPath("//span[contains(text(),'There was an upload error.')]"));


        }

        public void ChangeWindow()
        {
            Driver.DriverInstance.SwitchTo().Frame(Driver.DriverInstance.FindElement(By.XPath("//iframe[@class='KA-JQ']")));
            
        }
    }
}
