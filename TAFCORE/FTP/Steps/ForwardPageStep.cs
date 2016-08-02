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
            fp.ButtonAddForwordingAddress.Click();
            fp.TbEmail.ClearAndType(email);
            fp.ButtonNext.Click();
            fp.ConfirmForwarding();
        }



        public static void SaveRBChange()
        {
            ForwardPage fp = new ForwardPage();
            fp.RbForwordCopy.Click();
            fp.ButtonSaveChanges.Click();
            System.Threading.Thread.Sleep(1000);
            fp.LinkForwardSetting.Click();
        }


        public static void SetFilterSettings(string email)
        {
            ForwardPage fp = new ForwardPage();
            fp.LinkCreatingFilter.Click();
            fp.TbEmail2.ClearAndType(email);
            fp.CheckOnCkeckTextBox();
        }

        public static void RemoveForwarding()
        {
            ForwardPage fp = new ForwardPage();
            fp.RemoveForwarding();
        }
    }
}
