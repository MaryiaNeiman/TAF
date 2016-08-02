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
    public class SettingPage : BasePage
    {
        public Link LinkForwardSetting { get; private set; } = new Link(By.XPath("//a[contains(.,'Forwarding and POP/IMAP')]"));
        public Link LinkThemes { get; private set; } = new Link(By.XPath("//a[contains(.,'Themes')]"));
        public Button ButtonDelete { get; set; } 
        public Link LinkGeneral { get; private set; } = new Link(By.XPath("//a[contains(.,'General')]"));

        public SettingPage()
        {
            //LinkForwardSetting = new Link();
            //LinkForwardSetting.by = (By.XPath("//a[contains(.,'Forwarding and POP/IMAP')]"));
            //LinkThemes = new Link();
            //LinkThemes.by = (By.XPath("//a[contains(.,'Themes')]"));
            //LinkGeneral = new Link();
            //LinkGeneral.by = (By.XPath("//a[contains(.,'General')]"));

        }


    }
}
