using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;
using OpenQA.Selenium.Support.UI;

namespace TAFCORE.Elements
{
    public abstract class Element
    {
        public By by { get; set; }
        public IWebElement WrappedElement
        {
            get
            {
                return Driver.DriverInstance.FindElement(this.by);
            }
        }

        public Element()
        {

        }
        public Element(By by)
        {
            this.by = by;
        }
        public bool isDisplayed()
        {
            return WrappedElement.Displayed;


        }

        public bool isEnabled()
        {
            return WrappedElement.Enabled;


        }

        public void Click()
        {
            WrappedElement.Click();
        }

        public bool Selected
        {
            get { return WrappedElement.Selected; }
        }

        public void WaitUntilVisible(By by)
        {

            WebDriverWait wait = new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(by));

        }


        public void WaitUntilClickable(By by)
        {
            WebDriverWait wait = new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }

        //bool isPresent(By by); 

        //bool isPresent();  

        //void setLocator(By locator); 


        //void waitForIsElementPresent(By locator);  

        //IWebElement getElement(); 

    }

}
