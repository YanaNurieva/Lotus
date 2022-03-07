using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Nurieva_kurs;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public UnitTest1()
        {

            bdController.save = false;

        }

        [TestMethod]
        public void AuthTest_loginmailru_true()
        {

            string login = "login@mail.ru";
            string password = "qwerty123";
            bool result = true;

            Assert.AreEqual(result, bdController.auth(login, password));

        }

        [TestMethod]
        public void AuthTest_loginmailcom_false()
        {

            string login = "login@mail.com";
            string password = "123qwerty";
            bool result = false;

            Assert.AreEqual(result, bdController.auth(login, password));

        }

        [TestMethod]
        public void RegTest_namegmailcom_true()
        {

            string login = "name@gmail.com";
            string password = "zxcvbn123";
            bool result = true;

            Assert.AreEqual(result, bdController.reg(login, password));

        }

        [TestMethod]
        public void RegTest_login1mailru_false()
        {

            string login = "login1@mail.ru";
            string password = "123qwerty";
            bool result = false;

            Assert.AreEqual(result, bdController.reg(login, password));

        }

        [TestMethod]
        public void ChanheTest_loginmailru_true()
        {

            string login = "login@mail.ru";
            string password = "qwerty123";

            bdController.auth(login, password);

            try
            {

                bdController.changeFavorite(1);

            }
            catch (Exception ex) { Assert.Fail(ex.Message); }

            Assert.IsTrue(true);

        }

        [TestMethod]
        public void GetFlowerTest_loginmailru_true()
        {

            string login = "login@mail.ru";
            string password = "qwerty123";

            bdController.auth(login, password);

            Assert.IsTrue(bdController.GetFlowers().Count() > 0);

        }

        [TestMethod]
        public void AddOrderTest_loginmailru_true()
        {

            string login = "login@mail.ru";
            string password = "qwerty123";

            bdController.auth(login, password);

            try
            {

                bdController.AddOrder(1, 1, "test", "11111111111");

            }
            catch (Exception ex) { Assert.Fail(ex.Message); }

            Assert.IsTrue(true);

        }

    }
}
