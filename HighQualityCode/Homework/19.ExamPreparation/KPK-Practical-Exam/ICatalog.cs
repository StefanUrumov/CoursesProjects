
namespace KpkPracticalExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface ICatalog
    {
        IEnumerable<IContent> GetListContent(string title, int numberOfContentElementsToList);
        int UpdateContent(string oldUrl, string newUrl);
        void Add(IContent content);
    }
}
