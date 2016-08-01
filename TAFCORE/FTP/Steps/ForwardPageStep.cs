using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;
using TAFCORE.Utility.WebDriver;

namespace FTP.Steps
{
    public class ForwardPageStep:Step
    {

        public static void AddForwordingAddress(string email)
        {
            ForwardPage fp = new ForwardPage();
            fp.buttonAddForwordingAddress.Click();
            fp.tbEmail.ClearAndType(email);
            fp.buttonNext.Click();
            fp.ConfirmForwarding();
        }



        public static void SaveRBChange()
        {
            ForwardPage fp = new ForwardPage();
            fp.rbForwordCopy.Click();
            fp.buttonSaveChanges.Click();
            System.Threading.Thread.Sleep(1000);
            fp.linkForwardSetting.Click();
        }


        public static void SetFilterSettings(string email)
        {
            ForwardPage fp = new ForwardPage();
            fp.linkCreatingFilter.Click();
            fp.tbEmail2.ClearAndType(email);
            fp.CheckOnCkeckTextBox();
        }

        public static void RemoveForwarding()
        {
            ForwardPage fp = new ForwardPage();
            fp.RemoveForwarding();
        }
    }
}
