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
    public class TextBox : Element
    {
        public TextBox() { }

        public TextBox(By by) : base(by) { }

        void Type(String text)
        {
            try
            {
                WaitUntilVisible(this.by);
                WrappedElement.SendKeys(text);
            }
            catch (Exception ex)
            {
                LoggerHandler.WtiteErrorToLog("Text can't be enter", ex);
            }
        }


        void Clear()
        {
            WrappedElement.Clear();
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

        public string GetText()
        {
            try
            {
                return WrappedElement.Text;
            }
            catch (Exception ex)
            {
                LoggerHandler.WtiteErrorToLog("Text is absent", ex);
                return null;
            }
        }
    }

}
