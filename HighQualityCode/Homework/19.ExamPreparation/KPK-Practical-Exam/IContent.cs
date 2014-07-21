
namespace KpkPracticalExam
{
    using System;

    public interface IContent : IComparable
    {
        string Title { get; set; }
        string Author { get; set; }
        ulong Size { get; set; }
        string URL { get; set; }
        CatalogContentTypes Type { get; set; }
        string TextRepresentation { get; set; }
    }
}
