using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Page;
using CoreTAF.Utility.WebDriver;

namespace TAF.Steps
{
    public class ForwardPageStep
    {
     
        public static void AddForwordingAddress(string email)
        {
            ForwardPage fp = new ForwardPage();
            fp.ClickOnAddForwordingAddressButton();
            
            fp.SetEmail(email);
            fp.ClickOnButtonNext();
            fp.ConfirmForwarding();
        }

      

        public static void SaveRBChange()
        {
            ForwardPage fp = new ForwardPage();
            fp.ClickRadioButton();
            fp.SaveChanges();
            fp.ClickForwardSetting();
        }

      
        public static void SetFilterSettings(string email)
        {
            ForwardPage fp = new ForwardPage();
            fp.ClickOnLinkCreatingFilter();
            fp.SetFrom(email);
            fp.CheckOnCkeckTextBox();
        }
    }
}
