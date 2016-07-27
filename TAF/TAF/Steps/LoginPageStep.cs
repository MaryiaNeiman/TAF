using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Extention;
using OpenQA.Selenium;
using CoreTAF.Utility.WebDriver;
using TAF.Page;

namespace TAF.Steps

{
    public class LoginPageStep :Step
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

            else
            {
                if (lp.IsEmailTBDisplayedAndEnable())
                {
                    lp.SetTbEmail(email);
                    lp.ClickButtonNext();
                    lp.SetTbPassword(password);
                    lp.ClickButtonSignIn();
                }

                else
                {
                    lp.ClickOnHref();
                    AccountsPageStep.AddAccount();
                    LoginPageStep.SignIn(email, password);
                }
            }
         
        }
    }
}
