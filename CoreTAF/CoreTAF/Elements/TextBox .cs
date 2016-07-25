using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTAF.Utility.WebDriver;
namespace CoreTAF.Elements
{
    public class TextBox : Element
    {

        void type(String text) { }


        void clear() { }


       public void ClearAndType(String text)
        {
            Driver.DriverInstance.FindElement(this.by).Clear();
            Driver.DriverInstance.FindElement(this.by).SendKeys(text);
        }
    }

}
