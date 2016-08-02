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
        public Button ButtonAddForwordingAddress { get; private set; } = new Button(By.XPath("//input[@act='add']") );
        public TextBox TbEmail { get; private set; } = new TextBox(By.XPath("//div[@class='PN']/input"));
        public Button ButtonNext { get; private set; } = new Button(By.XPath("//button[@name='next']"));
        public RadioButton RbForwordCopy { get; private set; } = new RadioButton(By.XPath("//span[contains(.,'Forward a copy of incoming mail to')]/../preceding-sibling::td/input"));
        public Button ButtonSaveChanges { get; private set; } = new Button(By.XPath("//table/tbody/tr[4]/td/div/button[1]"));
        public Link LinkForwardSetting { get; private set; } = new Link(By.XPath("//span[contains(.,'Review Settings')]"));
        public Link LinkCreatingFilter { get; private set; } = new Link(By.XPath("//span[@act='filter']"));
        public TextBox TbEmail2 { get; private set; } = new TextBox(By.XPath("//label[contains(.,'From')]/../following-sibling::span/input"));




        public ForwardPage()
        {
            //ButtonAddForwordingAddress = new Button();
            //ButtonAddForwordingAddress.by = (By.XPath("//input[@act='add']"));
            //TbEmail = new TextBox();
            //TbEmail.by = (By.XPath("//div[@class='PN']/input"));
            //ButtonNext = new Button();
            //ButtonNext.by = (By.XPath("//button[@name='next']"));
            //RbForwordCopy = new RadioButton();
            //RbForwordCopy.by = (By.XPath("//span[contains(.,'Forward a copy of incoming mail to')]/../preceding-sibling::td/input"));
            //ButtonSaveChanges = new Button();
            //ButtonSaveChanges.by = (By.XPath("//table/tbody/tr[4]/td/div/button[1]"));
            //LinkCreatingFilter = new Link();
            //LinkCreatingFilter.by = (By.XPath("//span[@act='filter']"));
            //LinkForwardSetting = new Link();
            //LinkForwardSetting.by = (By.XPath("//span[contains(.,'Review Settings')]"));
            //TbEmail2 = new TextBox();
            //TbEmail2.by = (By.XPath("//label[contains(.,'From')]/../following-sibling::span/input"));

        }



        public void RemoveForwarding()
        {
            Driver.DriverInstance.FindElement(By.XPath("//span[contains(.,'Forward a copy of incoming mail to')]/select/option[contains(text(),'Remove')]")).Click();
            Button buttonOk = new Button();
            buttonOk.by = (By.XPath("//button[@name='ok']"));
            buttonOk.Click();
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
