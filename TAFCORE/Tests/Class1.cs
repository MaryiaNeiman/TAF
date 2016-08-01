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

            User user4 = new User("maryia.neiman@hmail.com", "14121995Mm");
        }
        [TestCleanup]
        public void TestCleanup()
        {
           InBoxPageStep.SignOutAccount();
            //LoginPageStep.SignIn(user1.Email, user1.Password);
            //InBoxPageStep.GoToSpam();
            //InBoxPageStep.MoveMailFromSpam(user1.Email);
            //InBoxPageStep.DeleteAllMail();
            //InBoxPageStep.SignOutAccount();
            
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Step.ClosePage(); 
        }

        [TestMethod]
       
        public void MyTestMethod1()
        {
            //1
            LoginPageStep.OpenGmail();
            //LoginPageStep.SignIn(user1.Email, user1.Password);
            ////2
            //InBoxPageStep.SendMassage(user2.Email, "Test" , Serves.GetCountry());
            ////3
            //InBoxPageStep.SignOutAccount();
            //LoginPageStep.SignIn(user2.Email, user2.Password);
            ////4
            //InBoxPageStep.MoveMailIntoSpam(user1.Email);
            ////5
            //InBoxPageStep.SignOutAccount();
            //LoginPageStep.SignIn(user1.Email, user1.Password);
            ////6
            //InBoxPageStep.SendMassage(user2.Email, "Test2", "Hello");
            ////7
            //InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            //8
            InBoxPageStep.GoToSpam();
            //assert
            Assert.IsTrue(InBoxPageStep.CheckLetter(user1.Email, "Test2"));
            //clear
           


        }
        [Ignore]
        [TestMethod]
        public void TestLogger()
        {
            Step st = new Step();
            st.PrintMessage();
            
        }

     
        
        [TestMethod]
        public void MyTestMethod3()
        {
            //1
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user1.Email, user1.Password);
            //2,3,4
            InBoxPageStep.SendMassageWithAttach(user2.Email, "Test5", "File", "C:\\Users\\Maryia_Neiman\\1.rar");
            //allert
            Assert.IsTrue(InBoxPageStep.AlertIsPresent());
            //clear
            InBoxPageStep.CancelAlert();


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
            //clear
            ThemePageStep.CloseWindow();
        }

        [TestMethod]
        public void MyTestMethod11()
        {
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            //2
            InBoxPageStep.SendMassage(user1.Email, "Test6", "Hello");
            //3
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user1.Email, user1.Password);
            //4
            InBoxPageStep.MoveMailIntoSpam(user2.Email);
            InBoxPageStep.GoToSpam();
            InBoxPageStep.MoveMailFromSpam(user2.Email);
            InBoxPageStep.GoToInBoxPage();
            Assert.IsTrue(InBoxPageStep.CheckLetter(user2.Email, "Test6"));
        }

        [TestMethod]
        public void MyTestMethod12()
        {
            string signature = "Olga Basko";
            LoginPageStep.OpenGmail();
            LoginPageStep.SignIn(user3.Email, user3.Password);
            InBoxPageStep.ChooseSettings();
            GeneralPageStep.InputSignature(signature);
            Assert.AreEqual(signature, InBoxPageStep.GetSignature());
            //clear
            InBoxPageStep.CloseFormForMail();
            InBoxPageStep.ChooseSettings();           
            GeneralPageStep.DeleteSignature();
        }

    }
}
