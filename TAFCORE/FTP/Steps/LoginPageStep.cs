using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;
using FTP.Page;

namespace FTP.Steps

{
    public class LoginPageStep : Step
    {
        private static string URL_PAGE = "https://www.gmail.com";
        public static void OpenGmail()
        {
            LoginPage lp = new LoginPage(URL_PAGE);
            lp.GoToPage();
        }


        public static void SignIn(string email, string password)
        {
            LoginPage lp = new LoginPage(URL_PAGE);
            if (!lp.IsEmailTBPresent())
            {
                AccountsPageStep.AddAccount();
                LoginPageStep.SignIn(email, password);
            }

            else if (lp.IsEmailTBDisplayedAndEnable())
            {
                lp.TbEmail.ClearAndType(email);
                lp.ButtonNext.Click();
                lp.TbPassword.ClearAndType(password);
                lp.ButtonSignIn.Click();
            }

            else
            {
                lp.Link.Click();
                AccountsPageStep.AddAccount();
                LoginPageStep.SignIn(email, password);
            }

        }
    }
}
