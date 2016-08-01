using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAFCORE.Utility.Logger
{
    public class LoggerHandler
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void WriteToLog(string text)
        {
            log.Info(text);
        }

        public static void WtiteErrorToLog(string text, Exception ex)
        {
            log.Error(text, ex);
        }

    }
}
