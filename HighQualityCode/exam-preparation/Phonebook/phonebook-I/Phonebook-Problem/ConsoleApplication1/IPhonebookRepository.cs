
namespace Phonebook
{
    //Documentation can be found at "bin\Debug\Phonebook.XML".
    using System.Collections.Generic;

    /// <summary>
    /// Interface that insures consistent phone book data
    /// </summary>
    public interface IPhonebookRepository
    {
        /// <summary>
        /// Provides adding contact functionlity
        /// </summary>
        /// <param name="userName">Active user client</param>
        /// <param name="phoneNumbers">Phone numbers related to current user</param>
        /// <returns></returns>
        bool AddPhone(string userName, IEnumerable<string> phoneNumbers);

        /// <summary>
        /// Provides managing state of user's phone numbers saved
        /// </summary>
        /// <param name="oldPhoneNumber">Phone number to be replaced</param>
        /// <param name="newPhoneNumber">Phone number to be added</param>
        /// <returns></returns>
        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);

        /// <summary>
        /// Provides generated information about user and it's phone numbers
        /// </summary>
        /// <param name="startIndex">record</param>
        /// <param name="count">to be returned</param>
        /// <returns></returns>
        PhonebookEntry[] ListEntries(int startIndex, int count);
    }
}


//To generate an XML documentation file for a Visual C# project
//With a project selected in Solution Explorer, on the Project menu, click Properties.
//Click the Build tab.
//On the Build page, select XML documentation file. By default, the file is created under the specified output path, for example, "bin\Debug\Projectname.XML".