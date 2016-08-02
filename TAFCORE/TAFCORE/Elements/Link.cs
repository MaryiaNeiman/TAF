using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Utility.WebDriver;
using TAFCORE.Utility.Logger;
using OpenQA.Selenium;
namespace TAFCORE.Elements
{
    public class Link : Element
    {
        public Link() { }
       
        public Link(By by) : base(by) { }
        

        public void Click()
        {

            try
            {

            WaitUntilVisible(this.by);
            WaitUntilClickable(this.by);
            WrappedElement.Click();
            LoggerHandler.WriteToLog("Link Click");
            }
            catch (Exception ex)
            {
                LoggerHandler.WtiteErrorToLog("Link Unclickable", ex);
            }
        }
    }
}
