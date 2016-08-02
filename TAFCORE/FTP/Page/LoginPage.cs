using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Page;
using TAFCORE.Elements;
using TAFCORE.Utility.WebDriver;
using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;

namespace FTP.Page
{
    class LoginPage : BasePage
    {


        public Button ButtonNext { get; private set; } = new Button(By.Id("next"));
        public Button ButtonSignIn { get; private set; } = new Button(By.Id("signIn"));
        public TextBox TbEmail { get; private set; } = new TextBox(By.Id("Email"));
        public TextBox TbPassword { get; private set; } = new TextBox(By.Id("Passwd"));
        public Link Link { get; private set; } = new Link(By.XPath("//a[@id='account-chooser-link']"));


        public LoginPage(string url) : base(url)
        {
            //ButtonNext = new Button();
            //ButtonNext.by = (By.Id("next"));
            //ButtonSignIn = new Button();
            //ButtonSignIn.by = (By.Id("signIn"));
            //TbEmail = new TextBox();
            //TbEmail.by = (By.Id("Email"));
            //TbPassword = new TextBox();
            //TbPassword.by = (By.Id("Passwd"));
            //Link = new Link();
            //Link.by = (By.XPath("//a[@id='account-chooser-link']"));
            //link.by = (By.XPath("//a[contains(.,'Sign in with a different account']"));
        }

        public bool IsEmailTBDisplayedAndEnable()
        {

            return TbEmail.isDisplayed() && TbEmail.isEnabled();

        }
        public bool IsEmailTBPresent()
        {

            return Driver.DriverInstance.IsElementPresent(TbEmail.by);

        }






    }
}
