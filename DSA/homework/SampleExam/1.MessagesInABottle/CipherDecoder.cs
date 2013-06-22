using System.Collections.Generic;
using System.Text;

namespace _1.MessagesInABottle
{
    class CipherDecoder
    {
        readonly List<CipherItem> cipherItems;
        readonly string secretCode;
        List<string> originalMessages;

        public CipherDecoder(string secretCode, string cipher)
        {
            cipherItems = new List<CipherItem>();

            StringBuilder currentCipher = new StringBuilder();
            char lastChar = '\0';
            foreach (char ch in cipher)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    if (currentCipher.Length > 0)
                    {
                        cipherItems.Add(new CipherItem(lastChar, currentCipher.ToString()));
                        currentCipher.Clear();
                    }
                    lastChar = ch;
                }
                else
                {
                    currentCipher.Append(ch);
                }
            }
            if (currentCipher.Length > 0)
            {
                cipherItems.Add(new CipherItem(lastChar, currentCipher.ToString()));
            }

            this.secretCode = secretCode;
        }

        char[] currentOriginalMessage = new char[100];

        private void AddSolution(char[] currentOriginalMessage)
        {
            StringBuilder originalMessage = new StringBuilder();
            foreach (char c in currentOriginalMessage)
            {
                if (c < 'A' || c > 'Z')
                    break;
                originalMessage.Append(c);
            }
            originalMessages.Add(originalMessage.ToString());
        }

        private void DecodeWithRecursion(int index, int wordIndex)
        {
            if (index == secretCode.Length)
            {
                AddSolution(currentOriginalMessage);
                return;
            }
            if (index > secretCode.Length)
                return;
            foreach (var item in cipherItems)
            {
                if (secretCode.Length >= index + item.Code.Length && secretCode.Substring(index, item.Code.Length) == item.Code)
                {
                    currentOriginalMessage[wordIndex] = item.Letter;
                    DecodeWithRecursion(index + item.Code.Length, wordIndex + 1);
                    currentOriginalMessage[wordIndex] = '\0';
                }
            }
        }

        public List<string> Decode()
        {
            originalMessages = new List<string>();
            DecodeWithRecursion(0, 0);
            return originalMessages;
        }
    }
}