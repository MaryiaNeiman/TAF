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

namespace TAF.Page

{
    public class SettingPage : BasePage
    {
        Link linkForwardSetting;


        public SettingPage()
        {
            linkForwardSetting = new Link();           
            linkForwardSetting.by = (By.XPath("//a[contains(.,'Forwarding and POP/IMAP')]"));
           
        }

        public void ClickOnForwarding()
        {
            Driver.DriverInstance.WaitUntilVisible(linkForwardSetting.by);
            linkForwardSetting.Click();
        }
    }
}
