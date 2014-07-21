
namespace PhonebookHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IPhonebookRepository
    {
        /// <summary>
        /// This method allows contact numbers to be added in the phonebook. The names are unique
        /// and case-insensitive.
        /// </summary>
        /// <param name="name">A person contact name must be entered</param>
        /// <param name="phoneNumbers">The count of easch contact numbers can be in range 1..10 </param>
        /// <returns></returns>
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);

        /// <summary>
        /// This method allows contact numbers to be changed in the phonebook. And your contacts to be updated when needed. 
        /// </summary>
        /// <param name="oldPhoneNumber">User must provide old number</param>
        /// <param name="newPhoneNumber">User must know the new contact phone number</param>
        /// <returns></returns>
        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);

        /// <summary>
        /// This method allows contact numbers to be listed in the phonebook. Also provides paging. The phonebook asumes 
        /// that entries are sorted by name case-insensitive way.
        /// </summary>
        /// <param name="startIndex">Is zero based and marks the beging of the list search</param>
        /// <param name="count">Specifies the page size of the list search</param>
        /// <returns></returns>
        PhonebookContacts[] List(int startIndex, int count);
    }
}
