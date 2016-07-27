using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Page;

namespace TAF.Steps
{
    public class MessageStep
    {
        public static void ConfirmForwarding()
        {
            Message m = new Message();
            m.ClickOnLink();
            m.ClickConfirm();
        }
    }
}
