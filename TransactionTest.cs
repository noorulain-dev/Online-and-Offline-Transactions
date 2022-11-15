using System;
using SplashKitSDK;
using NUnit.Framework;

namespace Passtask3{

    [TestFixture()]

    public class TransactionTest{

        [Test()]
        public void OnlineTestCreditCard(){
            Online onlineCC = new Online(280, Online.PaymentMode.CreditCard, "date");
            Assert.AreEqual(onlineCC.Amounts, onlineCC.Amounts, onlineCC.Date, onlineCC.Mode);
        }

        [Test()]
        public void OnlineTestPayPal(){
            Online onlinePP = new Online(280, Online.PaymentMode.Paypal, "date");
            Assert.AreEqual(onlinePP.Amounts, onlinePP.Amounts, onlinePP.Date, onlinePP.Mode);
        }

        [Test()]
        public void OfflineTestTrue(){
            Offline offlineTrue = new Offline(280, "3/3/2021", true);
            Assert.AreEqual(offlineTrue.Amounts, offlineTrue.Amounts, offlineTrue.Date, offlineTrue.State);
        }

        [Test()]
        public void OfflineTestFalse(){
            Offline offlineFalse = new Offline(280, "4/4/2021", false);
            Assert.AreEqual(offlineFalse.Amounts, offlineFalse.Amounts, offlineFalse.Date, offlineFalse.State);
        }

        [Test()]
        public void BonusPointsTest(){
            Offline offlineTrue = new Offline(280, "3/3/2021", true);
            Assert.AreEqual(33, offlineTrue.UpdatePoints());
        }
    }
}