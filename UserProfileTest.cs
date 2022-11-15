using System;
using NUnit.Framework;

namespace Passtask3{

    [TestFixture()]

    public class UserProfileTest{

        [Test()]
        public void AddTesting(){
            UserProfile myUserProfile = new UserProfile();
            int count = myUserProfile.TransactionTotal;

            Assert.AreEqual(0,count);

            myUserProfile.AddTransaction(new Online(280, Online.PaymentMode.Paypal, "date"));
            myUserProfile.AddTransaction(new Offline(280, "4/4/2021", false));

            count = myUserProfile.TransactionTotal;

            Assert.AreEqual(2,count);
        }

        [Test()]
        public void RemoveTesting(){
            UserProfile myUserProfile = new UserProfile();
            int count = myUserProfile.TransactionTotal;

            Assert.AreEqual(0,count);

            Transaction[] TestTransaction = {
                new Online(280, Online.PaymentMode.CreditCard, "date"),
                new Offline(280, "3/3/2021", true),
                new Offline(280, "4/4/2021", false)
            };

            foreach(Transaction t in TestTransaction){
                myUserProfile.AddTransaction(t);
            }

            count = myUserProfile.TransactionTotal;

            Assert.AreEqual(3,count);

            myUserProfile.RemoveTransaction(TestTransaction[2]);

            count = myUserProfile.TransactionTotal;

            Assert.AreEqual(2,count);
        }

        [Test()]

        public void FetchingTransaction(){
            UserProfile myUserProfile = new UserProfile();

            myUserProfile.AddTransaction(new Online(280, Online.PaymentMode.CreditCard, "date"));
            myUserProfile.AddTransaction(new Offline(280, "3/3/2021", true));

            Assert.AreEqual(280,myUserProfile[0].Amounts);
            StringAssert.AreEqualIgnoringCase("3/3/2021",myUserProfile[1].Date);
            Assert.AreEqual(280, myUserProfile[1].Amounts);
            StringAssert.AreEqualIgnoringCase("Payment Mode = Offline",myUserProfile[1].StringMessage());

        }

        [Test()]

        public void StatusTesting(){
            UserProfile myUserProfile = new UserProfile();
            Transaction[] transaction_ = {
                new Online(280, Online.PaymentMode.CreditCard, "date"),
                new Offline(280, "4/4/2021", false)
            };

            foreach(Transaction t in transaction_){
                myUserProfile.AddTransaction(t);
            }

            myUserProfile.update_status();
            Assert.AreEqual(myUserProfile.status, "Normal");
            
        }


    }
}