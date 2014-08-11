using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonebook;
using Wintellect.PowerCollections;

namespace PhonebookUnitTests
{
    //PhonebookRepository	-> Covered(Blocks)	55	-> Covered(% Blocks) 98,21 %
    [TestClass]
    public class PhonebookTests
    {
        internal static object GetInstanceField(Type type, object instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static;
            FieldInfo field = type.GetField(fieldName, bindFlags);
            return field.GetValue(instance);
        }

        //add_phone tests
        [TestMethod]
        public void ShouldAddPhoneWhenCalled()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            List<String> numbers = new List<string>();
            numbers.Add("0898 123 456");
            numbers.Add("((02) 9811111");
            repo.AddPhone(userName, numbers);
            Assert.AreNotEqual(null, repo);
        }

        [TestMethod]
        public void ShouldNotAddEmptyPhoneEntryWhenCalled()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "";
            List<String> numbers = new List<string>();
            repo.AddPhone(userName, numbers);
            Assert.AreEqual(null, repo);
        }

        [TestMethod]
        public void ShouldAddEmptyPhonesEntryWhenCalled()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            List<String> numbers = new List<string>();
            repo.AddPhone(userName, numbers);
            Assert.AreNotEqual(null, repo);
        }

        [TestMethod]
        public void ShouldAddEmptyUsernameWithPhonesWhenCalled()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "";
            List<String> numbers = new List<string>();
            numbers.Add("088 322 33 44");
            numbers.Add("((+359) 899 777236");
            numbers.Add("+359899777235");
            repo.AddPhone(userName, numbers);
            Assert.AreNotEqual(null, repo);
        }

        [TestMethod]
        public void ShouldMergeUserPhonesWhenCalled()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            string phone = "088 322 33 44";
            List<String> numbers = new List<string>();
            numbers.Add(phone);
            repo.AddPhone(userName, numbers);
            numbers.Clear();
            string phoneNew = "((+359) 899 777236";
            numbers.Add(phoneNew);
            repo.AddPhone(userName, numbers);
            
            var testObj = GetInstanceField(typeof (PhonebookRepository), repo, "_sortedEntries");
            string result = testObj.ToString();

            Assert.IsTrue(result.Contains(phone));
            Assert.IsTrue(result.Contains(phoneNew));
        }

        [TestMethod]
        public void ShouldNotAddUserWhenDuplicate()
        {
            PhonebookRepository repo = new PhonebookRepository();

            List<String> numbers = new List<string>();
            string userName = "test";
            string phone = "088 322 33 44";
            numbers.Add(phone);
            string phoneNew = "((+359) 899 777236";
            numbers.Add(phoneNew);
            repo.AddPhone(userName, numbers);

            List<String> numbersNew = new List<string>();
            string userNameSame = "test";
            string phoneNewUser = "088 322 33 45";
            numbersNew.Add(phoneNewUser);
            string phone2NewUser = "((+359) 899 777237";
            numbersNew.Add(phone2NewUser);
            repo.AddPhone(userNameSame, numbersNew);

            var testObj = GetInstanceField(typeof(PhonebookRepository), repo, "_sortedEntries");
            string result = testObj.ToString();

            Assert.IsTrue(result.Contains(phoneNewUser));
            Assert.IsTrue(result.Contains(phone2NewUser));
        }

        [TestMethod]
        public void ShouldNotAddNewNumbersWhenDuplicate()
        {
            PhonebookRepository repo = new PhonebookRepository();

            List<String> numbers = new List<string>();
            string userName = "test";
            string phone = "088 322 33 44";
            numbers.Add(phone);
            string phoneNew = "((+359) 899 777236";
            numbers.Add(phoneNew);
            repo.AddPhone(userName, numbers);

            List<String> numbersNew = new List<string>();
            string userNameSame = "test";
            string phoneNewUser = "088 322 33 44";
            numbersNew.Add(phoneNewUser);
            string phone2NewUser = "((+359) 899 777236";
            numbersNew.Add(phone2NewUser);
            repo.AddPhone(userNameSame, numbersNew);

            var list = repo.ListEntries(0, 1);
            Assert.AreEqual(2, list[0].PhoneNumbers.Count);
        }

        //change_phone tests
        [TestMethod]
        public void ShouldChangeUserPhonesWhenCalled()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            string phone = "088 322 33 44";
            List<String> numbers = new List<string>();
            numbers.Add(phone);
            string phoneNew = "((+359) 899 777236";
            repo.AddPhone(userName, numbers);
            repo.ChangePhone(phone, phoneNew);
            var testObj = GetInstanceField(typeof(PhonebookRepository), repo, "_sortedEntries");
            string result = testObj.ToString();

            Assert.IsFalse(result.Contains(phone));
            Assert.IsTrue(result.Contains(phoneNew));
        }

        [TestMethod]
        public void ShouldNotChangeUserPhonesWhenDuplicate()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            string phone = "088 322 33 44";
            List<String> numbers = new List<string>();
            numbers.Add(phone);
            repo.AddPhone(userName, numbers);
            repo.ChangePhone(phone, phone);
            var testObj = GetInstanceField(typeof(PhonebookRepository), repo, "_sortedEntries");
            string result = testObj.ToString();

            Assert.IsTrue(result.Contains(phone));
        }

        //list_phones tests
        [TestMethod]
        public void ShouldListUserPhonesWhenCalled()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            string phone = "088 322 33 44";
            string phoneNew = "((+359) 899 777236";
            List<String> numbers = new List<string>();
            
            numbers.Add(phone);
            numbers.Add(phoneNew);
            repo.AddPhone(userName, numbers);
            
            var list = repo.ListEntries(0, 1);
            Assert.AreEqual(userName, list[0].FirstName);
            Assert.AreEqual(2, list[0].PhoneNumbers.Count);
        }

        [TestMethod]
        public void ShouldNotListWhenNoUsersAdded()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            string phone = "088 322 33 44";
            string phoneNew = "((+359) 899 777236";
            List<String> numbers = new List<string>();

            numbers.Add(phone);
            numbers.Add(phoneNew);
            //repo.AddPhone(userName, numbers);

            var list = repo.ListEntries(0, 1);
            Assert.AreEqual(null, list[0]);
        }

        [TestMethod]
        public void ShouldNotListWhenBiggerCount()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            string phone = "088 322 33 44";
            string phoneNew = "((+359) 899 777236";
            List<String> numbers = new List<string>();

            numbers.Add(phone);
            numbers.Add(phoneNew);
            repo.AddPhone(userName, numbers);

            var list = repo.ListEntries(5, 10);
            Assert.AreEqual(null, list[0]);
        }

        [TestMethod]
        public void ShouldNotListWhenNegativeCount()
        {
            PhonebookRepository repo = new PhonebookRepository();

            string userName = "test";
            string phone = "088 322 33 44";
            string phoneNew = "((+359) 899 777236";
            List<String> numbers = new List<string>();

            numbers.Add(phone);
            numbers.Add(phoneNew);
            repo.AddPhone(userName, numbers);

            PhonebookEntry[] list = null;
            try
            {
                list = repo.ListEntries(-5, -10);
            }
            catch(OverflowException ofe)
            {
                Assert.AreEqual(null, list);
            }
        }
        

    }
}
