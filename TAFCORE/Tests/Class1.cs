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
        private User user2 = new User("testtafip1@gmail.com", " !qwer1qaz");
        private User user3 = new User("oab27041964@gmail.com", "27041964OAB");

      

        [ClassInitialize]
        public static void ClassInitialize(TestContext t)
            {
            LoginPageStep.OpenGmail();
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
           InBoxPageStep.SignOutAccount();
           LoginPageStep.SignIn(user1.Email, user1.Password);
            InBoxPageStep.GoToSpam();
            InBoxPageStep.MoveMailFromSpam(user1.Email);
            InBoxPageStep.DeleteAllMail();
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user2.Email, user2.Password);
            InBoxPageStep.DeleteAllMail();
            LoginPageStep.SignIn(user3.Email, user3.Password);
            InBoxPageStep.DeleteAllMail();
            InBoxPageStep.SignOutAccount();
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
            
            LoginPageStep.SignIn(user1.Email, user1.Password);
            //2
            InBoxPageStep.SendMassage(user2.Email, "Test", Serves.GetCountry());
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
            LoginPageStep.SignIn(user1.Email, user1.Password);
            //2,3,4
            InBoxPageStep.SendMassageWithAttach(user2.Email, "Test5", "File", Resource1.PathToBigFile);
            //allert
            Assert.IsTrue(InBoxPageStep.AlertIsPresent());
            //clear
            InBoxPageStep.CancelAlert();


        }
        [TestMethod]
        public void MyTestMethod4()
        {
            //1           
            LoginPageStep.SignIn(user2.Email, user2.Password);
            InBoxPageStep.ChooseSettings();
            //2
            SettingPageStep.GoToThemes();
            ThemePageStep.SetTheme(Resource1.Theme);
            //assert
            Assert.IsTrue(ThemePageStep.CheckMessageIsPresent());
            //clear
            ThemePageStep.CloseWindow();
        }

        [TestMethod]
        public void MyTestMethod11()
        {
           
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
            string signature = Resource1.Signature;          
            LoginPageStep.SignIn(user3.Email, user3.Password);
            InBoxPageStep.ChooseSettings();
            GeneralPageStep.InputSignature(signature);
            Assert.AreEqual(signature, InBoxPageStep.GetSignature());
            //clear
            InBoxPageStep.CloseFormForMail();
            InBoxPageStep.ChooseSettings();           
            GeneralPageStep.DeleteSignature();
        }

        [TestMethod]
        public void MyTestMethod5()
        {
            LoginPageStep.SignIn(user1.Email, user1.Password);
            InBoxPageStep.AddEmoticons(user3.Email, "Emoticons");
            Assert.IsTrue(InBoxPageStep.EmoticonsIsPresent());
            InBoxPageStep.ChooseEmotionsIcons(Int32.Parse(Resource1.CountOfEmoticons));
            InBoxPageStep.GoToInBoxPage();
            InBoxPageStep.SignOutAccount();
            LoginPageStep.SignIn(user3.Email, user3.Password);
            InBoxPageStep.ClickOnLinkInMail(user1.Email);
            Assert.IsTrue(InBoxPageStep.EmoticonsIsPresentInMail());
        }

    }
}
