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
            tp.linkSetThemes.Click();
            tp.buttonMyPhoto.Click();
            tp.ChangeWindow();
            tp.buttonUploadPhoto.Click();
            tp.buttonSelectedPhotoFromComputer.Click();
            Attachment.AttachFile(path);
        }

        public static bool CheckMessageIsPresent()
        {
            ThemesPage tp = new ThemesPage();
            return Driver.DriverInstance.IsElementPresent(tp.labelMessage.by);
        }
    }
}
