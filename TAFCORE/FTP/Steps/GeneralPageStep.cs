using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;
using System.Threading;

namespace FTP.Steps
{
    public class GeneralPageStep
    {
        public static void InputSignature(string signature)
        {
            GeneralPage gp = new GeneralPage();
            gp.RbSignature1.Click();
            gp.TbText.ClearAndType(signature);
            Thread.Sleep(4000);
            gp.ButtonSave.Click();
            Thread.Sleep(4000);
        }

        public static void DeleteSignature()
        {
            GeneralPage gp = new GeneralPage();
            gp.RbSignature0.Click();
            gp.ButtonSave.Click();
        }
    }
}
