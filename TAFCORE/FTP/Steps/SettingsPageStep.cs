using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;

namespace FTP.Steps
{
    public class SettingPageStep : Step
    {
        public static void ForwardMail()

        {
            SettingPage sp = new SettingPage();
            sp.LinkForwardSetting.Click();
        }

        public static void GoToThemes()

        {
            SettingPage sp = new SettingPage();
            sp.LinkThemes.Click();
        }

        public static void GoToGeneral()
        {
            SettingPage sp = new SettingPage();
            sp.LinkGeneral.Click();
        }

    }
}
