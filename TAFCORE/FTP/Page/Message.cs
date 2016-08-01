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
    public class Message : BasePage
    {
        public Link link;
        public Button buttonConfirm;

        public Message()
        {
            link = new Link();
            link.by = (By.XPath("//a[4]"));
            buttonConfirm = new Button();
            buttonConfirm.by = (By.XPath("//input[@type='submit']"));
        }

        public void ClickConfirm()
        {
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.Last());
            buttonConfirm.Click();
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.First());
        }

    }
}
