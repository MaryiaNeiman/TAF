using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Elements;
using TAFCORE.Page;
using OpenQA.Selenium;
using TAFCORE.Utility.WebDriver;
using TAFCORE.Utility.Logger;

using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;

namespace FTP.Page
{
    public class ForwardPage : BasePage
    {
        public Button buttonAddForwordingAddress;
        public TextBox tbEmail;
        public Button buttonNext;
        public RadioButton rbForwordCopy;
        public Button buttonSaveChanges;
        public Link linkForwardSetting;
        public Link linkCreatingFilter;
        public TextBox tbEmail2;


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
            linkForwardSetting = new Link();
            linkForwardSetting.by = (By.XPath("//span[contains(.,'Review Settings')]"));
            tbEmail2 = new TextBox();
            tbEmail2.by = (By.XPath("//label[contains(.,'From')]/../following-sibling::span/input"));

        }





        public void ConfirmForwarding()
        {
            Button buttonProceed = new Button();
            buttonProceed.by = (By.XPath("//input[@value='Proceed']"));
            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.Last());
            buttonProceed.Click();


            Driver.DriverInstance.SwitchTo().Window(Driver.DriverInstance.WindowHandles.First());
            Button buttonOk = new Button();
            buttonOk.by = (By.XPath("//button[@name='ok']"));

            buttonOk.Click();

        }




        public void CheckOnCkeckTextBox()
        {
            CheckBox cbHasAttachment = new CheckBox();
            cbHasAttachment.by = (By.XPath("//label[contains(.,'Has attachment')]/preceding-sibling::input"));
            cbHasAttachment.Select();

            Link linkCreateNextFilter = new Link();
            linkCreateNextFilter.by = (By.XPath("//div[contains(text(),'Create filter with this search')]"));

            linkCreateNextFilter.Click();

            CheckBox cbDeleteIt = new CheckBox();
            cbDeleteIt.by = (By.XPath("//label[contains(.,'Delete it')]/preceding-sibling::input"));

            cbDeleteIt.Select();

            CheckBox cbCheckBoxMarkImporpant = new CheckBox();
            cbCheckBoxMarkImporpant.by = (By.XPath("//label[contains(text(),'Always mark it as important')]/preceding-sibling::input"));
            cbCheckBoxMarkImporpant.Click();

            Button buttenCreateFilter = new Button();
            buttenCreateFilter.by = (By.XPath("//div[contains(text(),'Create filter')]"));
            buttenCreateFilter.Click();
        }




    }
}
