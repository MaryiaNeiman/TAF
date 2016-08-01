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
    class AccountsPage : BasePage
    {
        public Link addAccount;

        public AccountsPage()
        {
            addAccount = new Link();
            addAccount.by = (By.XPath("//a[@id='account-chooser-add-account']"));
        }



    }
}
