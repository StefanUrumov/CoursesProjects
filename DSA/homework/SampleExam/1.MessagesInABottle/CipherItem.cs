using System;

namespace _1.MessagesInABottle
{
    class CipherItem
    {
        public char Letter { get; set; }

        public string Code { get; set; }

        public CipherItem(char letter, string code)
        {
            this.Letter = letter;
            this.Code = code;
        }
    }
}