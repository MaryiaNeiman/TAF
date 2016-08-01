using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Utility.WebDriver;
using TAFCORE.Utility.Logger;
namespace TAFCORE.Elements
{
    public class TextBox : Element
    {

        void Type(String text)
        {
            WaitUntilVisible(this.by);
            WrappedElement.SendKeys(text);
        }


        void Clear()
        {
            WrappedElement.FindElement(this.by).Clear();
        }


        public void ClearAndType(String text)
        {
            try
            {
                WaitUntilVisible(this.by);
                WrappedElement.Clear();
                WrappedElement.SendKeys(text);
                LoggerHandler.WriteToLog("Enter the text");
            }
            catch (Exception ex)
            {
                LoggerHandler.WtiteErrorToLog("Text can't be enter", ex);
            }
        }
    }

}
