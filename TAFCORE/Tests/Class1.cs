using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTP.BusinessObject;
using FTP.Steps;

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
            //1
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user1.Email, user1.Password);
            //2
            InBoxPageStep.SendMassage(user2.Email, "Test", "Hello");
            //3
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            //4
            InBoxPageStep.MoveMailIntoSpam(user1.Email);
            //5
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user1.Email, user1.Password);
            //6
            InBoxPageStep.SendMassage(user2.Email, "Test2", "Hello");
            //7
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            //8
            InBoxPageStep.GoToSpam();
            //assert
            Assert.IsTrue(InBoxPageStep.CheckLetter(user1.Email, "Test2"));


        }
        [Ignore]
        [TestMethod]
        public void TestLogger()
        {
            Step st = new Step();
            st.PrintMessage();
            
        }

        [Ignore]
        [TestMethod]
        public void MyTestMethod2()
        {
            //1
            LoginPageStep.OpenGmail();
            //LoginPageStep.SignIn(user2.Email, user2.Password);
            ////2
            //InBoxPageStep.ChooseSettings();
            ////4
            //SettingPageStep.ForwardMail();
            ////5
            //ForwardPageStep.AddForwordingAddress(user3.Email);
            ////6
            //InBoxPageStep.SignOutAccount();
            //LoginPageStep.SignIn(user3.Email, user3.Password);
            ////7
            //InBoxPageStep.ClickOnLinkInMail("forwarding-noreply@google.com");
            //MessageStep.ConfirmForwarding();
            ////8
            //InBoxPageStep.SignOutAccount();
            //LoginPageStep.SignIn(user2.Email, user2.Password);
            ////9,10
            //InBoxPageStep.ChooseSettings();
            //SettingPageStep.ForwardMail();
            //ForwardPageStep.SaveRBChange();

            ////11,12
            ForwardPageStep.SetFilterSettings(user1.Email);
            ////13
            //InBoxPageStep.SignOutAccount();
            //LoginPageStep.SignIn(user1.Email, user1.Password);
            ////15
            //InBoxPageStep.SendMassage(user2.Email, "Test3", "Hello");
            ////14
            InBoxPageStep.SendMassageWithAttach(user2.Email, "Test4", "File", "C:\\Users\\Maryia_Neiman\\Pictures\\1.jpg");
            ////16
            // InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            //asssert
            Assert.IsTrue(TrashPageStep.CheckLetterInTrash(user1.Email, "Test4"));
            Assert.IsTrue(ImportantPageStep.CheckLetterInImportant(user1.Email, "Test4", "Test3"));
            Assert.IsTrue(InBoxPageStep.CheckLetter(user1.Email, "Test3"));
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user3.Email, user3.Password);
            Assert.IsTrue(InBoxPageStep.CheckLetter(user1.Email, "Test3"));

        }
        [Ignore]
        [TestMethod]
        public void MyTestMethod3()
        {
            //1
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            //2,3,4
            InBoxPageStep.SendMassageWithAttach(user1.Email, "Test5", "File", "C:\\Users\\Maryia_Neiman\\Jenkins.7z");
            //allert
            Assert.IsTrue(InBoxPageStep.AlertIsPresent());
            
        }
        [TestMethod]
        public void MyTestMethod4()
        {
            //1
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            InBoxPageStep.ChooseSettings();
            //2
            SettingPageStep.GoToThemes();
            ThemePageStep.SetTheme("C:\\q\\log.jpg");
            //assert
            Assert.IsTrue(ThemePageStep.CheckMessageIsPresent());

        }

    }
}
