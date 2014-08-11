
namespace PhonebookApplication
{
    using System.Collections.Generic;

    interface IPhonebookRepository
    {
        /// <summary>
        /// Adds contacts to phonebook repository.
        /// </summary>
        /// <param name="name">Contact person name</param>
        /// <param name="phoneNumbers">Contact phones</param>
        /// <returns></returns>
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);

        /// <summary>
        /// Changes and updates contact's phones
        /// </summary>
        /// <param name="oldPhoneNumber">Phone to be replaced</param>
        /// <param name="newPhoneNumber">Phone updated</param>
        /// <returns></returns>
        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);

        /// <summary>
        /// Displays information about contacts details.
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Entry[] ListEntries(int startIndex, int count);
    }
}
