using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;
using TAFCORE.Utility.Attachment;
using TAFCORE.Utility.WebDriver;
namespace FTP.Steps
{
   public class ThemePageStep
    {

        public static void SetTheme(string path)
        {
            ThemesPage tp = new ThemesPage();
            tp.LinkSetThemes.Click();
            tp.ButtonMyPhoto.Click();
            tp.ChangeWindow();
            tp.ButtonUploadPhoto.Click();
            tp.ButtonSelectedPhotoFromComputer.Click();
            Attachment.AttachFile(path);
        }

        public static bool CheckMessageIsPresent()
        {
            ThemesPage tp = new ThemesPage();
            return Driver.DriverInstance.IsElementPresent(tp.LabelMessage.by);
        }

        public static void CloseWindow()
        {
            ThemesPage tp = new ThemesPage();
            tp.ButtonClose.Click();
            tp.GoToFirstWindow();
            tp.ButtonClose2.Click();
        }
    }
}
