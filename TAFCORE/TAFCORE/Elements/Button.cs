using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TAFCORE.Utility.Logger;
namespace TAFCORE.Elements
{
    public class Button : Element
    {
        public Button()
        {

        }
        public Button(By by) : base(by)
        {
           
        }

        public void Click()
        {
            try
            {
                WaitUntilVisible(this.by);
                WaitUntilClickable(this.by);
                WrappedElement.Click();
                LoggerHandler.WriteToLog("Button Click");
                
            }
            catch (Exception ex)
            {
                LoggerHandler.WtiteErrorToLog("Button Unclickable", ex);
            }
        }

        //IWebElement getElement(); 
    }

}
