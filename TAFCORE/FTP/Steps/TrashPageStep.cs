using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;
using System.Threading;
using TAFCORE.Utility.WebDriver;

namespace FTP.Steps
{
    public class TrashPageStep
    {
        public static /*bool*/ void CheckLetternTrash(string email, string text)
        {
            TrashPage tp = new TrashPage();

            InBoxPage inp = new InBoxPage();
            bool result = inp.CheckLetter(email, text);
        }


        public static bool CheckLetterInTrash(string email, string text)
        {
            TrashPage tp = new TrashPage();
            return tp.CheckLetter(email, text);
        }

        public static void DeleteAllMail()
        {
            Thread.Sleep(5000);
            TrashPage tp = new TrashPage();
            tp.SelectAllMail();
            tp.ButtonDelete.Click();
        }

    }


}
