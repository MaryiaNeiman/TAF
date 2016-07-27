using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTAF.Page;
using CoreTAF.Elements;
using CoreTAF.Utility.WebDriver;
using OpenQA.Selenium;
using TAF.Extention;

namespace TAF.Page
{
    class LoginPage : BasePage
    {

       
        Button buttonNext;
        Button buttonSignIn;
        TextBox tbEmail;
        TextBox tbPassword;
        Link link;
           

        public LoginPage(string url) : base (url) 
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

            //return Driver.DriverInstance.IsElementPresent(tbEmail.by);
           return tbEmail.isDisplayed() && tbEmail.isEnabled();

        }
        public bool IsEmailTBPresent()
        {

            return Driver.DriverInstance.IsElementPresent(tbEmail.by);
           
        }
        //public bool IsPasswordTBDisplayed()
        //{
        //    return Driver.DriverInstance.IsElementPresent(tbPassword.by);
        //}
        public void  SetTbEmail(string str)
        {
            tbEmail.ClearAndType(str);
        }

        public void SetTbPassword(string str)
        {
            Driver.DriverInstance.WaitUntilVisible(tbPassword.by);
            tbPassword.ClearAndType(str);
        }

        public void ClickButtonNext()
        {
            buttonNext.Click();
        }

        public void ClickButtonSignIn()
        {
            buttonSignIn.Click();
           
        }

        public void ClickOnHref()
        {
            Driver.DriverInstance.WaitUntilVisible(link.by);
            link.Click();

        }
    }
}
