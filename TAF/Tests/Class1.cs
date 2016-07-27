using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAF.Steps;
using TAF.BusinessObject;
namespace Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class GmailTests
    {
        private User user1 = new User("maryia.neiman@gmail.com", "14121995Mm");
        private User user2 = new User("asham1412987@gmail.com", "14121995Mm");
        private User user3 = new User("oab27041964@gmail.com", "27041964OAB");

        public GmailTests()
        {

            //User user4 = new User("maryia.neiman@hmail.com", "14121995Mm");
        }
        //[TestCleanup]
        //public void TestCleanup() { Step.ClosePage(); }
        [TestMethod]
        [Ignore]
        public void MyTestMethod1()
        {
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user1.Email, user1.Password);
            InBoxPageStep.SendMassage(user2.Email, "Test", "Hello");
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            InBoxPageStep.MoveMailIntoSpam(user1.Email);
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user1.Email, user1.Password);
            InBoxPageStep.SendMassage(user2.Email, "Test2", "Hello");
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            InBoxPageStep.GoToSpam();
            Assert.IsTrue(InBoxPageStep.CheckLetter(user1.Email, "Test2"));


        }
        [TestMethod]

        public void MyTestMethod2()
        {
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            InBoxPageStep.ChooseSettings();
            SettingPageStep.ForwardMail();
            ForwardPageStep.AddForwordingAddress(user3.Email);
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user3.Email, user3.Password);
            InBoxPageStep.ClickOnLinkInMail("forwarding-noreply@google.com");
            MessageStep.ConfirmForwarding();
            InBoxPageStep.SignOutAccount();

            LoginPageStep.SignIn(user2.Email, user2.Password);
            InBoxPageStep.ChooseSettings();
            SettingPageStep.ForwardMail();
            ForwardPageStep.SaveRBChange();

            //12,11
            ForwardPageStep.SetFilterSettings(user1.Email);
            //13

            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user1.Email, user1.Password);
            //14
            InBoxPageStep.SendMassageWithAttach(user2.Email, "Test3", "File", "C:\\Users\\Maryia_Neiman\\Pictures\\1.jpg");
            //15
            InBoxPageStep.SendMassage(user2.Email, "Test4", "Hello");
            //16
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
        }

    }
}
