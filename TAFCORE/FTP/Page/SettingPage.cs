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
        public Link linkForwardSetting;
        public Link linkThemes;
        public Button buttonDelete;
        public Link linkGeneral;

        public SettingPage()
        {
            linkForwardSetting = new Link();
            linkForwardSetting.by = (By.XPath("//a[contains(.,'Forwarding and POP/IMAP')]"));
            linkThemes = new Link();
            linkThemes.by = (By.XPath("//a[contains(.,'Themes')]"));
            linkGeneral = new Link();
            linkGeneral.by = (By.XPath("//a[contains(.,'General')]"));

        }


    }
}
