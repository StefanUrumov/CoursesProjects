﻿
namespace KpkPracticalExam
{
    using System;
    using System.Linq;

    public class Content : IComparable, IContent
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public ulong Size { get; set; }

        private string url;

        public string URL
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString(); // To update the text representation
            }
        }

        public CatalogContentTypes Type { get; set; }

        public string TextRepresentation { get; set; }

        public Content(CatalogContentTypes type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)CatalogItemsProperties.Title];
            this.Author = commandParams[(int)CatalogItemsProperties.Author];
            this.Size = ulong.Parse(commandParams[(int)CatalogItemsProperties.Size]);
            this.URL = commandParams[(int)CatalogItemsProperties.Url];
        }

        public int CompareTo(object obj)
        {
            if (null == obj)
                return 1;

            Content otherContent = obj as Content;
            if (otherContent != null)
            {
                Int32 comparisonResul = this.TextRepresentation.CompareTo(otherContent.TextRepresentation);

                return comparisonResul;
            }

            throw new ArgumentException("Object is not a Content");
        }

        public override string ToString()
        {
            string output = String.Format("{0}: {1}; {2}; {3}; {4}", this.Type.ToString(), this.Title, this.Author, this.Size, this.URL);

            return output;
        }
    }
}
