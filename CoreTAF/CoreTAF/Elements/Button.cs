using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using CoreTAF.Utility.WebDriver;

namespace CoreTAF.Elements
{
    public  class Button : Element
    { 
    public void Click()
        {
            Driver.DriverInstance.FindElement(this.by).Click();
        } 
 
 	    //IWebElement getElement(); 
 }

}
