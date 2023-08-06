// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Library_management;

class Program
{
    static void Main()
    {
        Library library = new Library("MyLibrary", "123 Main St");

        // Adding books to the library
        library.AddBook(new Book("Book 1", "Author 1", "ISBN-001", 2000));
        library.AddBook(new Book("Book 2", "Author 2", "ISBN-002", 2010));

        // Adding media items to the library
        library.AddMediaItem(new MediaItem("Movie 1", "DVD", 120));
        library.AddMediaItem(new MediaItem("Music Album 1", "CD", 60));

        // Print the library catalog
        library.PrintCatalog();
    }
}