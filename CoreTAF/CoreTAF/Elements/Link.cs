using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTAF.Utility.WebDriver;
namespace CoreTAF.Elements
{
    public class Link : Element
    {
        public void Click()
        {
            Driver.DriverInstance.FindElement(this.by).Click();
        }
    }
}
