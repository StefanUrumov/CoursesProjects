
namespace KpkPracticalExam
{
    using System;
    using System.Linq;

    public enum CommandContent
    {
        AddBook,
        AddMovie, 
        AddSong,
        AddApplication,
        Update, 
        Find
    };

    public enum CatalogContentTypes
    {
        Book,
        Movie,
        Music,
        Application
    };

    public enum CatalogItemsProperties
    {
        Title,    
        Author,
        Size,
        Url
    };
}
