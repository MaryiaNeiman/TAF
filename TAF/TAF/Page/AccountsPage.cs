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
    class AccountsPage : BasePage
    {
        Link addAccount;

        public AccountsPage()
        {
            addAccount = new Link();
            addAccount.by = (By.XPath("//a[@id='account-chooser-add-account']"));
        }

        public void ClickOnHref()
        {
            Driver.DriverInstance.WaitUntilVisible(addAccount.by);
            addAccount.Click();

        }
       
    }
}
