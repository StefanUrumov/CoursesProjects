using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonebookHost;

namespace Phonebook.Test
{
    [TestClass]
    public class PhonebookHostRepositoryTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "A contact entry must have phone number.")]
        public void TestAddPhoneNoEntries()
        {
            IPhonebookRepository numberBook = new PhonebookHostRepository();
            string [] numbers = new string []{
            "0899 777 235",
            "02 / 981 11 11",
            };

            var actual = numberBook.AddPhone("kalina", null);

            var  expected = numberBook.AddPhone("kalina", numbers);

            Assert.AreNotEqual(expected, actual);
        }


        [TestMethod]
        public void TestAddPhoneEmptyEntries()
        {
            IPhonebookRepository numberBook = new PhonebookHostRepository();
            string[] numbers = new string[]{
            "0899 777 235",
            "02 / 981 11 11",
            };

            string[] numbersZero = new string[]{};

            var actual = numberBook.AddPhone("kalina", numbersZero);

            var expected = numberBook.AddPhone("kalina", numbers);

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "A contact entry must have contact name.")]
        public void TestAddPhoneNoContactNameEntry()
        {
            IPhonebookRepository numberBook = new PhonebookHostRepository();
            string[] numbers = new string[]{
            "0899 777 235",
            "02 / 981 11 11",
            };

            var actual = numberBook.AddPhone(null, numbers);

            var expected = numberBook.AddPhone("kalina", numbers);

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "The start index and count must be positive!")]
        public void TestListNegativeEntries()
        {
            IPhonebookRepository numberBook = new PhonebookHostRepository();
            string[] numbers = new string[]{
            "0899 777 235",
            "02 / 981 11 11",
            };

            var actual = numberBook.List(-1, 2);

            var expected = numberBook.List(1, 2); 

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "The count of numbers must be in range 1-10!")]
        public void TestListTooManyEntries()
        {
            IPhonebookRepository numberBook = new PhonebookHostRepository();
           
            var actual = numberBook.List(1, 2000);

            var expected = numberBook.List(1, 2);

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]        
        public void TestChangePhone()
        {
            IPhonebookRepository numberBook = new PhonebookHostRepository();

            var actual = numberBook.ChangePhone("+359899777235", "+359883223344");

            var expected = numberBook.ChangePhone("+359899777235", "+359883223344");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestChangePhoneNullEntry()
        {
            IPhonebookRepository numberBook = new PhonebookHostRepository();

            var actual = numberBook.ChangePhone(null, "+359883223344");
            var expected = numberBook.ChangePhone("+359899777235", "+359883223344");           

            Assert.AreNotEqual(expected, actual);
        }

    }
}
