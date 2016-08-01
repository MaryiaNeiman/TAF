using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Utility.WebDriver;
using TAFCORE.Utility.Logger;
namespace TAFCORE.Elements
{
    public class Link : Element
    {
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
