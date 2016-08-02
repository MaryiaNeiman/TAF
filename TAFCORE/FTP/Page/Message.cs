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
        public Link Link { get; private set; } = new Link(By.XPath("//a[4]"));
        public Button ButtonConfirm { get; private set; } = new Button(By.XPath("//input[@type='submit']"));

        public Message()
        {
            //Link = new Link();
            //Link.by = (By.XPath("//a[4]"));
            //ButtonConfirm = new Button();
            //ButtonConfirm.by = (By.XPath("//input[@type='submit']"));
        }

        public void ClickConfirm()
        {
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.Last());
            ButtonConfirm.Click();
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.First());
        }

    }
}
