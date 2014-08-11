using System;

namespace FreeContentCatalogApplication
{
    public interface IContent : IComparable
    {
        string Title { get; set; }

        string Author { get; set; }

        Int64 Size { get; set; }

        string URL { get; set; }

        ContentItem Type { get; set; }

        string TextRepresentation { get; set; }
    }
}
