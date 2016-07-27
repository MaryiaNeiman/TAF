using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Page;

namespace TAF.Steps
{
   public class SettingPageStep : Step
    {
        public static void ForwardMail()

        {
            SettingPage sp = new SettingPage();
            sp.ClickOnForwarding();
        }
    }
}
