using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CodeWords
{
    class CodeXOR
    {
        static void Main()
        {
            Console.WriteLine("Enter text to be coded:");
            string text = Console.ReadLine();
            string code = "@#$%^&*+";

            Console.Write("Encrypted:");
            string encrypted = Encrypt(text, code);
            Console.WriteLine(encrypted);

            Console.Write("Decrypted:");
            string deCrypt = DeCrypt(encrypted, code);
            Console.WriteLine(deCrypt);
        }

        static string DeCrypt(string str, string code)
        {
            return Encrypt(str, code).ToString();
        }


        private static string Encrypt(string text, string code)
        {
            char[] textArr = text.ToCharArray();
            char[] codeArr = code.ToCharArray();

            StringBuilder encrypted = new StringBuilder();

            for (int index = 0, key = 0; index < textArr.Length; key++, index++)
            {
                if (!(key < code.Length))
                {
                    key = 0;
                }
                //codeArr[index] = code[key];
                encrypted.Append((char)(textArr[index] ^ codeArr[key]));
            }

            //for (int i = 0; i < textArr.Length; i++)
            //{
            //    encrypted.Append((char)(textArr[i] ^ codeArr[i]));
            //}

            return encrypted.ToString();
        }


    }
}
