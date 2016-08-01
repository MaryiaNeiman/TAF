using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFCORE.Page;
using TAFCORE.Utility.Logger;

namespace FTP.Steps
{
    public class Step
    {
        public static void ClosePage()
        {
            BasePage.ClosePage();
        }

        public void PrintMessage()
        {
            //Logger.GetLogger().Log("weqe");
            //Logger.GetLogger().Close();
            LoggerHandler.WriteToLog("!!!!");
        }
    }
}
