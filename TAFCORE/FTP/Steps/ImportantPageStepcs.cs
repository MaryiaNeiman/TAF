using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;
using System.Threading;

namespace FTP.Steps
{
    public class ImportantPageStep
    {
        public static bool CheckLetterInImportant(string email, string str1, string str2)
        {
            ImportantPage im = new ImportantPage();
            return im.CheckLetter(email, str1, str2);
        }

        public static void DeleteAllMail()
        {
            Thread.Sleep(5000);
            ImportantPage tp = new ImportantPage();
            tp.SelectAllMail();
            tp.ButtonDelete.Click();
        }
    }
}
