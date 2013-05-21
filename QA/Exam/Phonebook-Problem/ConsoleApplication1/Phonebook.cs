
namespace PhonebookHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Phonebook
    {
        private const string CurrentCountryPhoneCode = "+359";

        private static readonly IPhonebookRepository phonebookContactsData = new PhonebookHostRepository();
        private static readonly StringBuilder userInput = new StringBuilder();

        static void Main()
        {
            while (true)
            {
                string inputPhoneData = Console.ReadLine();

                if (inputPhoneData == "End" || inputPhoneData == null)
                {                    
                    break;
                }

                int openingBracketIndex = inputPhoneData.IndexOf('(');

                if (openingBracketIndex == -1)
                {
                    throw new FormatException("Incorrect sytax! Check the number of the brackets.");
                }

                string inputPhonebookCommand = inputPhoneData.Substring(0, openingBracketIndex);
                if (!inputPhoneData.EndsWith(")"))
                {
                    Main();
                }

                string contactDetails = inputPhoneData.Substring(openingBracketIndex + 1, inputPhoneData.Length - openingBracketIndex - 2);
                string[] contactDetailsArray = contactDetails.Split(',');

                for (int index = 0; index < contactDetailsArray.Length; index++)
                {
                    contactDetailsArray[index] = contactDetailsArray[index].Trim();
                }

                if ((inputPhonebookCommand.StartsWith("AddPhone")) && (contactDetailsArray.Length >= 2))
                {
                    PhonebookCommand("AddPhone", contactDetailsArray);
                }
                else if ((inputPhonebookCommand.StartsWith("ChangePhone")) && (contactDetailsArray.Length == 2))
                {
                    PhonebookCommand("ChangeРhone", contactDetailsArray);
                }
                else if ((inputPhonebookCommand.StartsWith("List")) && (contactDetailsArray.Length == 2))
                {
                    PhonebookCommand("List", contactDetailsArray);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Unknown command! Please use only predefined phonebook comands.");
                }
            }
            Console.Write(userInput);
        }

        private static void PhonebookCommand(string phonebookCommand, string[] contactInput)
        {
            if (phonebookCommand == "AddPhone") 
            {
                string contactName = contactInput[0];
                List<string> contactNumbersList = contactInput.Skip(1).ToList();
                
                for (int phoneNumber = 0; phoneNumber < contactNumbersList.Count; phoneNumber++)
                {
                    contactNumbersList[phoneNumber] = ExtractNumber(contactNumbersList[phoneNumber]);
                }

                bool isNewNumber = phonebookContactsData.AddPhone(contactName, contactNumbersList);

                if (isNewNumber)
                {
                    Print("Phone entry created");
                }
                else
                {
                    Print("Phone entry merged");
                }
            }
            else if (phonebookCommand == "ChangeРhone") 
            {
                Print("" + phonebookContactsData.ChangePhone(ExtractNumber(contactInput[0]), ExtractNumber(contactInput[1])) + " numbers changed");
            }
            else if (phonebookCommand == "List") 
            {
                try
                {
                    IEnumerable<PhonebookContacts> entries = phonebookContactsData.List(int.Parse(contactInput[0]), contactInput[1].Count());
                    
                    foreach (var entry in entries)
                    {
                        Print(entry.ToString());
                    }
                }
                //According to QA best practises an exception must be thrown here when the Method can't work with input user data
                // and not a message but task constraints...
                catch (ArgumentOutOfRangeException outsideOfList)
                {
                    Console.WriteLine("Invalid range");
                    //Console.WriteLine("An error has been found: {0}", outsideOfList.Message);
                    //Console.WriteLine("Plese see the stacktarce here: {0}", outsideOfList.StackTrace);
                }
            }
        }

        private static string ExtractNumber(string phoneNumber)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= userInput.Length; i++)
            {
                sb.Clear();
                foreach (var charDigit in phoneNumber)
                {
                    if (char.IsDigit(charDigit) || (charDigit == '+'))
                    {
                        sb.Append(charDigit);
                    }
                }
                
                if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')
                { 
                    sb.Remove(0, 1); sb[0] = '+'; 
                
                }
                while (sb.Length > 0 && sb[0] == '0')
                {
                    sb.Remove(0, 1);
                }

                if (sb.Length > 0 && sb[0] != '+')
                {
                    sb.Insert(0, CurrentCountryPhoneCode);
                }
                sb.Clear();

                foreach (char ch in phoneNumber)
                {
                    if (char.IsDigit(ch) || (ch == '+'))
                    {
                        sb.Append(ch);
                    }
                }

                if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')
                {
                    sb.Remove(0, 1); sb[0] = '+';
                }

                while (sb.Length > 0 && sb[0] == '0')
                {
                    sb.Remove(0, 1);
                }

                if (sb.Length > 0 && sb[0] != '+')
                {
                    sb.Insert(0, CurrentCountryPhoneCode);
                }

                sb.Clear();

                foreach (char ch in phoneNumber)
                {
                    if (char.IsDigit(ch) || (ch == '+'))
                    {
                        sb.Append(ch);
                    }
                }

                if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')
                {
                    sb.Remove(0, 1); sb[0] = '+';
                }

                while (sb.Length > 0 && sb[0] == '0')
                {
                    sb.Remove(0, 1);
                }

                if (sb.Length > 0 && sb[0] != '+') sb.Insert(0, CurrentCountryPhoneCode);
            }
            return sb.ToString();
        }

        private static void Print(string text)
        {
            userInput.AppendLine(text);
        }
    }

    
    //unused class
    //class UpdatedPhonebook : IPhonebookRepository
    //{
    //    public List<PhonebookContacts> phoneEntries = new List<PhonebookContacts>();

    //    public bool AddPhone(string contactPersonName, IEnumerable<string> contactPersonPhoneNumbers)
    //    {
    //        var existingContact = from name in this.phoneEntries
    //                              where name.ContactName.ToLowerInvariant() == contactPersonName.ToLowerInvariant()
    //                              select name;

    //        bool contactPhoneIsAdded;

    //        if (existingContact.Count() == 0)
    //        {
    //            PhonebookContacts newContact = new PhonebookContacts();
    //            newContact.ContactName = contactPersonName;
    //            newContact.PhonebookContactsData = new SortedSet<string>();

    //            foreach (var num in contactPersonPhoneNumbers)
    //            {
    //                newContact.PhonebookContactsData.Add(num);
    //            }

    //            this.phoneEntries.Add(newContact);
    //            contactPhoneIsAdded = true;
    //        }
    //        else if (existingContact.Count() == 1)
    //        {
    //            PhonebookContacts firstPhonebookContact = existingContact.First();

    //            foreach (var phoneNumber in contactPersonPhoneNumbers)
    //            {
    //                firstPhonebookContact.PhonebookContactsData.Add(phoneNumber);
    //            }

    //            contactPhoneIsAdded = false;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("Duplicated contactPersonName in the phonebook found: " + contactPersonName);
    //            // return false;
    //        }

    //        return contactPhoneIsAdded;
    //    }

    //    public int ChangePhone(string oldNumberEntry, string newNumberEntry)
    //    {
    //        var oldNumbersList = from oldNumber in this.phoneEntries
    //                             where oldNumber.PhonebookContactsData.Contains(oldNumberEntry)
    //                             select oldNumber;

    //        int numbersChanged = 0;

    //        foreach (var entry in oldNumbersList)
    //        {
    //            entry.PhonebookContactsData.Remove(oldNumberEntry);
    //            entry.PhonebookContactsData.Add(newNumberEntry);
    //            numbersChanged++;
    //        }
                       
    //        return numbersChanged; 
    //    }

    //    //probably private
    //    public PhonebookContacts[] List(int start, int contactPhoneNumbersCount)
    //    {
    //        if (start < 0 || start + contactPhoneNumbersCount > this.phoneEntries.Count) //10
    //        {
    //            throw new ArgumentOutOfRangeException("Invalid contact details! Please check the contact phones count. Must be in range[1..10]");
    //        }

    //        this.phoneEntries.Sort();

    //        PhonebookContacts[] phonebookItems = new PhonebookContacts[contactPhoneNumbersCount];

    //        //probably bug here
    //        for (int i = start; i <= start + contactPhoneNumbersCount - 1; i++)
    //        {
    //            PhonebookContacts entry = this.phoneEntries[i];
    //            phonebookItems[i - start] = entry;
    //        }
    //        return phonebookItems;
    //    }
    //}

   

   
}