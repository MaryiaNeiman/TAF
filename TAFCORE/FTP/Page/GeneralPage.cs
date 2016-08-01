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
      public  TextBox tbText;
        public RadioButton rbSignature1;
        public RadioButton rbSignature0;
        public Button buttonSave;
        public GeneralPage()
        {
            tbText = new TextBox();
            tbText.by = (By.XPath("//div[@aria-label='Signature']"));
            rbSignature1 = new RadioButton();
            rbSignature1.by = (By.XPath("//*[@name='sx_sg'][@value='1']"));
            rbSignature0 = new RadioButton();
            rbSignature0.by = (By.XPath("//*[@name='sx_sg'][@value='0']"));
            buttonSave = new Button();
            buttonSave.by = (By.XPath("//button[@guidedhelpid='save_changes_button']"));
        }
        
        
    }
}
