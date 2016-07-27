using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreTAF.Elements;
using CoreTAF.Page;
using OpenQA.Selenium;
using CoreTAF.Utility.WebDriver;
using TAF.Extention;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace TAF.Page
{
    public class ForwardPage : BasePage
    {
        Button buttonAddForwordingAddress;
        TextBox tbEmail;
        Button buttonNext;
        RadioButton rbForwordCopy;
        Button buttonSaveChanges;
        Link linkForwardSetting;
        Link linkCreatingFilter;
        Button buttonAttach;

        public ForwardPage()
        {
            buttonAddForwordingAddress = new Button();
            buttonAddForwordingAddress.by = (By.XPath("//input[@act='add']"));
            tbEmail = new TextBox();
            tbEmail.by = (By.XPath("//div[@class='PN']/input"));
            buttonNext = new Button();
            buttonNext.by = (By.XPath("//button[@name='next']"));
            rbForwordCopy = new RadioButton();
            rbForwordCopy.by = (By.XPath("//span[contains(.,'Forward a copy of incoming mail to')]/../preceding-sibling::td/input"));
            buttonSaveChanges = new Button();
            buttonSaveChanges.by = (By.XPath("//table/tbody/tr[4]/td/div/button[1]"));
            linkCreatingFilter = new Link();
            linkCreatingFilter.by = (By.XPath("//span[@act='filter']"));
            
        }

        public void ClickOnAddForwordingAddressButton()
        {
            Driver.DriverInstance.WaitUntilVisible(buttonAddForwordingAddress.by);
            buttonAddForwordingAddress.Click();
        }

        public void SetEmail(string email)
        {
            Driver.DriverInstance.WaitUntilVisible(tbEmail.by);
            tbEmail.ClearAndType(email);
        }

        public void ClickOnButtonNext()
        {
            
            buttonNext.Click();
        }

        public void ConfirmForwarding()
        {
            Button buttonProceed = new Button();
            buttonProceed.by = (By.XPath("//input[@value='Proceed']"));

            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.Last());

            // Cause the popup to appear
            Driver.DriverInstance.WaitUntilVisible(buttonProceed.by);
            buttonProceed.Click();
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.First());
            Button buttonOk = new Button();
            buttonOk.by = (By.XPath("//button[@name='ok']"));
            Driver.DriverInstance.WaitUntilVisible(buttonOk.by);
            buttonOk.Click();
                        
        }

        public void ClickRadioButton()
        {
            rbForwordCopy.Click();
        }
        public void SaveChanges()
        {
            Driver.DriverInstance.WaitUntilClickable(buttonSaveChanges.by);
            buttonSaveChanges.Click();
        }

        public void ClickForwardSetting()
        {
            
            System.Threading.Thread.Sleep(1000);
            Driver.DriverInstance.WaitUntilVisible(By.XPath("//span[contains(.,'Review Settings')]"));
            Driver.DriverInstance.WaitUntilClickable(By.XPath("//span[contains(.,'Review Settings')]"));
            linkForwardSetting = new Link();
            linkForwardSetting.by = (By.XPath("//span[contains(.,'Review Settings')]"));
            linkForwardSetting.Click();
        }

        public void ClickOnLinkCreatingFilter()
        {
            Driver.DriverInstance.WaitUntilClickable(linkCreatingFilter.by);
            linkCreatingFilter.Click();
        }

        public void SetFrom(string email)
        {
            TextBox tbEmail = new TextBox();
            tbEmail.by = (By.XPath("//label[contains(.,'From')]/../following-sibling::span/input"));
            tbEmail.ClearAndType(email);
        }

        public void CheckOnCkeckTextBox()
        {
            CheckBox cbHasAttachment = new CheckBox();
            cbHasAttachment.by = (By.XPath("//label[contains(.,'Has attachment')]/preceding-sibling::input"));
            cbHasAttachment.Click();

            Link linkCreateNextFilter = new Link();
            linkCreateNextFilter.by = (By.XPath("//div[contains(text(),'Create filter with this search')]"));
            Driver.DriverInstance.WaitUntilClickable(linkCreateNextFilter.by);
            linkCreateNextFilter.Click();

            CheckBox cbDeleteIt = new CheckBox();
            cbDeleteIt.by = (By.XPath("//label[contains(.,'Delete it')]/preceding-sibling::input"));
            Driver.DriverInstance.WaitUntilVisible(cbDeleteIt.by);
            Driver.DriverInstance.WaitUntilClickable(cbDeleteIt.by);
            cbDeleteIt.Click();

            CheckBox cbCheckBoxMarkImporpant = new CheckBox();
            cbCheckBoxMarkImporpant.by = (By.XPath("//label[contains(text(),'Always mark it as important')]/preceding-sibling::input"));
            cbCheckBoxMarkImporpant.Click();

            Button buttenCreateFilter = new Button();
            buttenCreateFilter.by = (By.XPath("//div[contains(text(),'Create filter')]"));
            buttenCreateFilter.Click();
        }

      


    }
}
