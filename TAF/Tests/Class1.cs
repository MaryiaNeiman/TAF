using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Steps;

namespace Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class GmailTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn("asham1412987", "14121995Mm");
            InBoxPageStep.SendMassage("maryia.neiman@gmail.com","Test","Hello");
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn("Maryia.Neiman", "14121995Mm");
            InBoxPageStep.SelectLetter("asham1412987@gmail.com");
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn("asham1412987", "14121995Mm");
            InBoxPageStep.SendMassage("maryia.neiman@gmail.com", "Test", "Hello");
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn("Maryia.Neiman", "14121995Mm");
            InBoxPageStep.GoToSpam();
            Assert.IsTrue(InBoxPageStep.CheckLetter("asham1412987@gmail.com", "Test"));
        }
    }
}
