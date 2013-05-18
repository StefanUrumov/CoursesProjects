
namespace KpkPracticalExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    class Catalog : ICatalog
    {
        private readonly MultiDictionary<string, IContent> url;
        private  readonly OrderedMultiDictionary<string, IContent> title;

        public Catalog()
        {
            bool allowDuplicateValues = true;
            this.title = new OrderedMultiDictionary<string, IContent>(allowDuplicateValues);
            this.url = new MultiDictionary<string, IContent>(allowDuplicateValues);
        }

        public void Add(IContent content)
        {
            this.title.Add(content.Title, content);
            this.url.Add(content.URL, content);
        }

        public IEnumerable<IContent> GetListContent(string title, Int32 numberOfContentElementsToList)
        {
            IEnumerable<IContent> contentToList = from content in this.title[title] select content;

            return contentToList.Take(numberOfContentElementsToList);
        }


        public int UpdateContent(string oldUrl, string newUrl)
        {
            int theElements = 0;
            List<IContent> contentToList = this.url[oldUrl].ToList();


            foreach (IContent content in contentToList)
            {
                this.title.Add(content.Title, content);
                this.url.Add(content.URL, content);
                this.title.Remove(content.Title, content);
                content.URL = newUrl;
                theElements++; //increase updatedElements
            }

            this.url.Remove(oldUrl);

            return theElements;
        }
    }
}
