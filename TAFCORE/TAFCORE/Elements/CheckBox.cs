using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;
using TAFCORE.Utility.Logger;

namespace TAFCORE.Elements
{
    public class CheckBox : Element
    {
        public CheckBox()
        {

        }
        public CheckBox(By by) : base(by)
        {

        }

        public void Select()
        {
            try
            {


                if (!Selected)
                {
                    WaitUntilVisible(this.by);
                    WaitUntilClickable(this.by);
                    WrappedElement.Click();
                    LoggerHandler.WriteToLog("CheckBox Selected");
                }
            }
            catch(Exception ex)
            {
                LoggerHandler.WtiteErrorToLog("CheckBox can't be select", ex);
            }
        }

        public void Deselect()
        {
            if (Selected)
            {
                WaitUntilVisible(this.by);
                WaitUntilClickable(this.by);
                WrappedElement.Click();
            }
        }

        bool isSelect() { return true; }

    }

}
