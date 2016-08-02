using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Elements;
using TAFCORE.Page;
using TAFCORE.Utility.WebDriver;
using OpenQA.Selenium;
namespace FTP.Page
{
    public class GeneralPage
    {
        public TextBox TbText { get; private set; } = new TextBox(By.XPath("//div[@aria-label='Signature']"));
        public RadioButton RbSignature1 { get; private set; } = new RadioButton(By.XPath("//*[@name='sx_sg'][@value='1']"));
        public RadioButton RbSignature0 { get; private set; } = new RadioButton(By.XPath("//*[@name='sx_sg'][@value='0']"));
        public Button ButtonSave { get; private set; } = new Button(By.XPath("//button[@guidedhelpid='save_changes_button']"));

        public GeneralPage()
        {
        //    TbText = new TextBox();
        //    TbText.by = (By.XPath("//div[@aria-label='Signature']"));
        //    RbSignature1 = new RadioButton();
        //    RbSignature1.by = (By.XPath("//*[@name='sx_sg'][@value='1']"));
        //    RbSignature0 = new RadioButton();
        //    RbSignature0.by = (By.XPath("//*[@name='sx_sg'][@value='0']"));
        //    ButtonSave = new Button();
        //    ButtonSave.by = (By.XPath("//button[@guidedhelpid='save_changes_button']"));
        }
        
        
    }
}
