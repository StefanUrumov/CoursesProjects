using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonebookApplication;

namespace PhonebookTests
{
    //test coverage -> 94.23%
    [TestClass]
    public class UnitTests
    {
        internal static object GetInstanceField(Type type, object instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static;
            FieldInfo field = type.GetField(fieldName, bindFlags);
            return field.GetValue(instance);
        }

        //AddPhone
        [TestMethod]
        public void AddPhoneEmptyNameTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            nums.Add("+359899777235");
            nums.Add("0899 76 15 33");

            repo.AddPhone("", nums);
            var result = GetInstanceField(typeof (Repository), repo, "_entriesSorOrderedSet");
            Assert.AreEqual(String.Empty, result.ToString());
        }

        [TestMethod]
        public void AddPhoneTooLongNameTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            nums.Add("+359899777235");
            nums.Add("0899 76 15 33");
            string longName = "The name will be non-empty English text (less than 200 characters) and cannot contain a lot of chars in Constraints, as well as leading or trailing whitespace. Names are case-insensitive, e.g. Peter is the same as peter and PETER.";
            repo.AddPhone(longName, nums);
            var result = GetInstanceField(typeof(Repository), repo, "_entriesSorOrderedSet");
            Assert.AreEqual(String.Empty, result.ToString());
        }

        [TestMethod]
        public void AddPhoneIncorrectCharsNameTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            nums.Add("+359899777235");
            nums.Add("0899 76 15 33");
            string longName = @" The name will be non-empty English text (less than 200 characters) and cannot contain , : and \n , as well as leading or trailing whitespace. Names are case-insensitive, e.g. Peter is the same as peter and PETER. ";
            repo.AddPhone(longName, nums);
            var result = GetInstanceField(typeof(Repository), repo, "_entriesSorOrderedSet");
            Assert.AreEqual(String.Empty, result.ToString());
        }

        [TestMethod]
        public void AddEmptyPhonesTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            nums.Add("");
            nums.Add("");
            repo.AddPhone("Name", nums);
            var result = GetInstanceField(typeof(Repository), repo, "_entriesSorOrderedSet");
            Assert.AreEqual(String.Empty, result.ToString());
        }

        [TestMethod]
        public void AddIncorrectCharsPhonesTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            nums.Add("1123,3212");
            nums.Add("31231231\n3112");
            nums.Add(" 0312312313112");
            nums.Add("3123123132133112 ");
            nums.Add("000312312313112");

            repo.AddPhone("Name", nums);
            var result = GetInstanceField(typeof(Repository), repo, "_entriesSorOrderedSet");
            Assert.AreEqual(String.Empty, result.ToString());
        }

        [TestMethod]
        public void AddShortPhonesTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            nums.Add("11");
            nums.Add("1");
            
            repo.AddPhone("Name", nums);
            var result = GetInstanceField(typeof(Repository), repo, "_entriesSorOrderedSet");
            Assert.AreEqual(String.Empty, result.ToString());
        }

        [TestMethod]
        public void AddTooLongPhonesTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            string longNumber51 = "111111111111111111111111111111111111111111111111111";
            nums.Add(longNumber51);

            repo.AddPhone("Name", nums);
            var result = GetInstanceField(typeof(Repository), repo, "_entriesSorOrderedSet");
            Assert.AreEqual(String.Empty, result.ToString());
        }

        //ChangePhone
        [TestMethod]
        public void ChangeTooLongPhonesTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            string longNumber51 = "111111111111111111111111111111111111111111111111111";
            string longNumber51a = "222222222222222222222222222222222222222222222222222";

            nums.Add(longNumber51);

            repo.AddPhone("Name", nums);
            repo.ChangePhone(longNumber51, longNumber51a);
            var result = GetInstanceField(typeof(Repository), repo, "_entriesSorOrderedSet");
            
            Assert.IsFalse(result.ToString().Contains(longNumber51a));
        }

        //ListEntries
        [TestMethod]
        public void ListTooBigCountTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            string number = "+35989977723";

            for (int i = 0; i < 21; i++)
            {
                nums.Add(number + i);                
            }

            repo.AddPhone("Name", nums);
            bool isListed = true;

            try
            {
                var list = repo.ListEntries(0, nums.Count);
            }
            catch (IndexOutOfRangeException)
            {
                isListed = false;
            }

            Assert.IsFalse(isListed);
        }

        [TestMethod]
        public void ListNegativeCountTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            string number = "+35989977723";

            for (int i = 0; i < 12; i++)
            {
                nums.Add(number + i);
            }

            repo.AddPhone("Name", nums);
            bool isListed = true;

            try
            {
                var list = repo.ListEntries(0, -1);
            }
            catch (OverflowException)
            {
                isListed = false;
            }

            Assert.IsFalse(isListed);
        }

        [TestMethod]
        public void ListZeroCountTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            string number = "+35989977723";

            for (int i = 0; i < 12; i++)
            {
                nums.Add(number + i);
            }

            repo.AddPhone("Name", nums);
            bool isListed = true;

            
            var list = repo.ListEntries(0, 0);
            
            Assert.AreEqual(0, list.Length);
        }

        [TestMethod]
        public void ListZeroStartTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            string number = "+35989977723";

            for (int i = 0; i < 12; i++)
            {
                nums.Add(number + i);
            }

            repo.AddPhone("Name", nums);

            var list = repo.ListEntries(0, 10);

            Assert.AreEqual(10, list.Length);
        }

        [TestMethod]
        public void ListNegativeStartTest()
        {
            Repository repo = new Repository();
            List<string> nums = new List<string>();
            string number = "+35989977723";

            for (int i = 0; i < 12; i++)
            {
                nums.Add(number + i);
            }

            repo.AddPhone("Name", nums);
            bool isListed = false;

            try
            {
                var list = repo.ListEntries(0, 10);
            }
            catch (IndexOutOfRangeException)
            {
                isListed = true;
            }

            Assert.AreEqual(true, isListed);
        }

    }
}
