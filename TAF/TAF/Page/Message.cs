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
    public class Message : BasePage
    {
        Link link;
        Button buttonConfirm;

        public Message()
        {
            link = new Link();
            link.by = (By.XPath("//a[4]"));
            buttonConfirm = new Button();
            buttonConfirm.by = (By.XPath("//input[@type='submit']"));
        }
        public void ClickOnLink()
        {
            Driver.DriverInstance.WaitUntilVisible(link.by);
            link.Click();
        }
        public void ClickConfirm()
        {
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.Last());
            buttonConfirm.Click();
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.First());
        }

    }
}
