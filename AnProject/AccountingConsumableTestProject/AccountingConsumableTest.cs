using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using AccountigConsumable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountingConsumableTestProject
{
    [TestClass]
    public class AccountingConsumableTest
    {
        [TestMethod]
        public void CheckGrantedAccessTodelInWorkersPage()
        {
            SenderMail SenderMail = new SenderMail();
            WorkersS Page = new WorkersS();
            SenderMail.PosName = "Администратор";
            bool Predict = true;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInWorkersPage()
        {
            SenderMail SenderMail = new SenderMail();
            WorkersS Page = new WorkersS();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(-2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessWithHalfDataTodelInWorkersPage()
        {
            SenderMail SenderMail = new SenderMail();
            WorkersS Page = new WorkersS();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInWorkersPageHalfData()
        {
            SenderMail SenderMail = new SenderMail();
            WorkersS Page = new WorkersS();
            SenderMail.PosName = "Администратор";
            bool Predict = false;
            bool result = Page.CheckForDel(0);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckGrantedAccessTodelInRoomPage()
        {
            SenderMail SenderMail = new SenderMail();
            RoomPage Page = new RoomPage();
            SenderMail.PosName = "Администратор";
            bool Predict = true;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInRoomPage()
        {
            SenderMail SenderMail = new SenderMail();
            RoomPage Page = new RoomPage();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(-2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessWithHalfDataTodelInRoomPage()
        {
            SenderMail SenderMail = new SenderMail();
            RoomPage Page = new RoomPage();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInRoomPageHalfData()
        {
            SenderMail SenderMail = new SenderMail();
            RoomPage Page = new RoomPage();
            SenderMail.PosName = "Администратор";
            bool Predict = false;
            bool result = Page.CheckForDel(0);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckGrantedAccessTodelInOrderInWarehouse()
        {
            SenderMail SenderMail = new SenderMail();
            OrderInWarehouse Page = new OrderInWarehouse();
            SenderMail.PosName = "Администратор";
            bool Predict = true;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInOrderInWarehouse()
        {
            SenderMail SenderMail = new SenderMail();
            OrderInWarehouse Page = new OrderInWarehouse();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(-2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessWithHalfDataTodelInOrderInWarehouse()
        {
            SenderMail SenderMail = new SenderMail();
            OrderInWarehouse Page = new OrderInWarehouse();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInOrderInWarehouseHalfData()
        {
            SenderMail SenderMail = new SenderMail();
            OrderInWarehouse Page = new OrderInWarehouse();
            SenderMail.PosName = "Администратор";
            bool Predict = false;
            bool result = Page.CheckForDel(0);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckGrantedAccessTodelInOrderConsumPage()
        {
            SenderMail SenderMail = new SenderMail();
            OrderConsumPage Page = new OrderConsumPage();
            SenderMail.PosName = "Администратор";
            bool Predict = true;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInOrderConsumPage()
        {
            SenderMail SenderMail = new SenderMail();
            OrderConsumPage Page = new OrderConsumPage();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(-2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessWithHalfDataTodelInOrderConsumPage()
        {
            SenderMail SenderMail = new SenderMail();
            OrderConsumPage Page = new OrderConsumPage();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInOrderConsumPageHalfData()
        {
            SenderMail SenderMail = new SenderMail();
            OrderConsumPage Page = new OrderConsumPage();
            SenderMail.PosName = "Администратор";
            bool Predict = false;
            bool result = Page.CheckForDel(0);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckGrantedAccessTodelInConsumPageAbout()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumPageAbout Page = new ConsumPageAbout();
            SenderMail.PosName = "Администратор";
            bool Predict = true;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInConsumPageAbout()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumPageAbout Page = new ConsumPageAbout();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(-2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessWithHalfDataTodelInOConsumPageAboutPage()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumPageAbout Page = new ConsumPageAbout();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInConsumPageAboutalfData()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumPageAbout Page = new ConsumPageAbout();
            SenderMail.PosName = "Администратор";
            bool Predict = false;
            bool result = Page.CheckForDel(0);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckGrantedAccessTodelInConsumablePage()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumablePage Page = new ConsumablePage();
            SenderMail.PosName = "Администратор";
            bool Predict = true;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInConsumablePage()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumablePage Page = new ConsumablePage();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(-2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessWithHalfDataTodelInOConsumablePage()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumablePage Page = new ConsumablePage();
            SenderMail.PosName = "Менеджер";
            bool Predict = false;
            bool result = Page.CheckForDel(2);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void CheckDeniedAccessTodelInConsumablePagealfData()
        {
            SenderMail SenderMail = new SenderMail();
            ConsumablePage Page = new ConsumablePage();
            SenderMail.PosName = "Администратор";
            bool Predict = false;
            bool result = Page.CheckForDel(0);
            Assert.AreEqual(Predict, result);
        }
        [TestMethod]
        public void WithSpecialSymbolLoginTest()
        {
            bool predict = true;
            string Login = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void WithoutSpecialSymbolLoginTest()
        {
            bool predict = false;
            string Login = "Abc312e";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void MinLenghtLoginTest()
        {
            bool predict = false;
            string Login = "asd";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void MaxLenghtLoginTest()
        {
            bool predict = false;
            string Login = "aW2faBasdasdhAScXzTasdaQWasTRVh@t$dasdasdasdasd";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void LoginWithUpperText()
        {
            bool predict = true;
            string Login = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void LoginWithoutUpperText()
        {
            bool predict = false;
            string Login = "aw241gc$";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void LoginWithLowerText()
        {
            bool predict = true;
            string Login = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void LoginWithoutLowerText()
        {
            bool predict = false;
            string Login = "AW241GC$";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void LoginWithNumberText()
        {
            bool predict = true;
            string Login = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void LoginWithoutNumerText()
        {
            bool predict = false;
            string Login = "AWsbeGC$";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.LoginCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void WithSpecialSymbolPasswordTest()
        {
            bool predict = true;
            string Password = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void WithoutSpecialSymbolPasswordTest()
        {
            bool predict = false;
            string Password = "Abc312e";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void MinLenghtPasswordTest()
        {
            bool predict = false;
            string Password = "asd";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void MaxLenghtPasswordTest()
        {
            bool predict = false;
            string Password = "aW2faBasdasdhAScXzTasdaQWasTRVh@t$dasdasdasdasd";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void PasswordWithUpperText()
        {
            bool predict = true;
            string Password = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void PasswordWithoutUpperText()
        {
            bool predict = false;
            string Password = "aw241gc$";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void PasswordWithLowerText()
        {
            bool predict = true;
            string Password = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void PasswordWithoutLowerText()
        {
            bool predict = false;
            string Password = "AW241GC$";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void PasswordWithNumberText()
        {
            bool predict = true;
            string Login = "Abc#2";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Login);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void PasswordWithoutNumerText()
        {
            bool predict = false;
            string Password = "AWsbeGC$";
            AuthorizationDataCheck AuData = new AuthorizationDataCheck();
            bool result = AuData.PasswordCheck(Password);
            Assert.AreEqual(predict, result);
        }
        [TestMethod]
        public void Check()
        {

        }
    }
}
