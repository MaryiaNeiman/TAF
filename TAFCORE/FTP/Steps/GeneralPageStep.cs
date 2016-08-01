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
            gp.rbSignature1.Click();
            gp.tbText.ClearAndType(signature);
            gp.buttonSave.Click();
        }

        public static void DeleteSignature()
        {
            GeneralPage gp = new GeneralPage();
            gp.rbSignature0.Click();
            gp.buttonSave.Click();
        }
    }
}
