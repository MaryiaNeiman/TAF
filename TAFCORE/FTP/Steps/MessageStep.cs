using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.Page;

namespace FTP.Steps
{
    public class MessageStep
    {
        public static void ConfirmForwarding()
        {
            Message m = new Message();
            m.Link.Click();
            m.ClickConfirm();
        }
    }
}
