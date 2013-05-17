using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CSharpStringsDescribe
{
    class DescribeStings
    {
        static void Main()
        {
            /*
                A C# string is an array of characters declared using the string keyword. A string literal is declared using quotation marks.
            We can extract substrings or concatenate strings. String objects are immutable, meaning that they cannot be changed once they have been
            created. Methods that act on strings actually return new string objects. In the previous example, when the contents of s1 and s2 are
            concatenated to form a single string, the two strings containing "orange" and "red" are both unmodified. The += operator creates a
            new string that contains the combined contents. The result is that s1 now refers to a different string altogether. A string containing 
            just "orange" still exists, but is no longer referenced when s1 is concatenated.
            Because modifications to strings involve the creation of new string objects, for performance reasons, large amounts of concatenation or other
            involved string manipulation should be performed with the StringBuilder class.
                The @ symbol tells the string constructor to ignore escape characters and line breaks.Like all objects derived from Object, strings provide 
            the ToString method, which converts a value to a string. This method can be used to convert numeric values into strings.Individual characters 
            contained in a string can be accessed using methods such as SubString(), Replace(), Split() and Trim(). It is also possible to copy the characters
            into a char array. Individual characters from a string can be accessed with an index. To change the letters in a string to upper or lower case, we use 
            ToUpper() or ToLower(). The simplest way to compare two strings is to use the == and != operators, which perform a case-sensitive comparison. 
                String objects also have a CompareTo() method that returns an integer value based on whether one string is less-than (<)or greater-than 
            (>) another. When comparing strings, the Unicode value is used, and lower case has a smaller value than upper case. To search for a string 
            inside another string, use IndexOf(). IndexOf() returns -1 if the search string is not found; otherwise, it returns the zero-based index of
            the first location at which it occurs.
                Splitting a string into substrings—such as splitting a sentence into individual words—is a common programming task. The Split() method takes
            a char array of delimiters, for example, a space character, and returns an array of substrings. You can access this array with foreach. An empty string
            is an instance of a System.String object that contains zero characters. Empty strings are used quite commonly in various programming scenarios
            to represent a blank text field. You can call methods on empty strings because they are valid System.String objects. Empty strings are initialized like this: string s = "".
            By contrast, a null string does not refer to an instance of a System.String object and any attempt to call a method on a null string results in a NullReferenceException.
            However, you can use null strings in concatenation and comparison operations with other strings. The following examples illustrate some cases in which a reference 
            to a null string does and does not cause an exception to be thrown. The StringBuilder class creates a string buffer that offers better performance if your 
            program performs a lot of string manipulation. The StringBuilder string also allows you to reassign individual characters, something the built-in string data 
            type does not support. This code, for example, changes the content of a string without creating a new string.
                */

        }
    }
}
