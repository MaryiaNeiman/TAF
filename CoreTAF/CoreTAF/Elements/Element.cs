using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using CoreTAF.Utility.WebDriver;

namespace CoreTAF.Elements
{
    public abstract class Element
    { 
       public By by { get; set; }

 	public bool isDisplayed()
        {
            return Driver.DriverInstance.FindElement(this.by).Displayed;


        }

        public bool isEnabled()
        {
            return Driver.DriverInstance.FindElement(this.by).Enabled;


        }

        public void Click()
        {
            Driver.DriverInstance.FindElement(this.by).Click();
        }

        //bool isPresent(By by); 

        //bool isPresent();  

        //void setLocator(By locator); 


        //void waitForIsElementPresent(By locator);  

        //IWebElement getElement(); 

    }

}
