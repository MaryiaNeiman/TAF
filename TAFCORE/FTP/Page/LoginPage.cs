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


        public Button buttonNext;
        public Button buttonSignIn;
        public TextBox tbEmail;
        public TextBox tbPassword;
        public Link link;


        public LoginPage(string url) : base(url)
        {
            buttonNext = new Button();
            buttonNext.by = (By.Id("next"));
            buttonSignIn = new Button();
            buttonSignIn.by = (By.Id("signIn"));
            tbEmail = new TextBox();
            tbEmail.by = (By.Id("Email"));
            tbPassword = new TextBox();
            tbPassword.by = (By.Id("Passwd"));
            link = new Link();
            link.by = (By.XPath("//a[@id='account-chooser-link']"));
            //link.by = (By.XPath("//a[contains(.,'Sign in with a different account']"));
        }

        public bool IsEmailTBDisplayedAndEnable()
        {

            return tbEmail.isDisplayed() && tbEmail.isEnabled();

        }
        public bool IsEmailTBPresent()
        {

            return Driver.DriverInstance.IsElementPresent(tbEmail.by);

        }






    }
}
