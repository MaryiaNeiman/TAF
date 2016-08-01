using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace TAFCORE.Utility.Logger
{
    public class Logger
    {
        public string pathWithNameFile = ConfigurationManager.AppSettings["Path"];
        private static Logger logger;
        private StreamWriter writer;

        private Logger()
        {
            try
            {
                writer = new StreamWriter(File.Create(pathWithNameFile));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Logger GetLogger()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }

        public void Log(String message)
        {
            writer.WriteLine(message);
        }

        public void Close()
        {
            writer.Flush();
            writer.Close();
           
        }
    }
}
