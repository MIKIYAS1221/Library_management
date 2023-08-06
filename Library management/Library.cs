namespace Library_management;

public class Library
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; set; }
    public List<MediaItem> MediaItems { get; set; }
    
    public Library(string name, string address)
    {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }
    
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book {book.Title} added to library {Name}");
    }
    
    public void AddMediaItem(MediaItem mediaItem)
    {
        MediaItems.Add(mediaItem);
        Console.WriteLine($"Media item {mediaItem.Title} added to library {Name}");
    }
    
    public void DeleteBook(Book book)
    {
        if (Books.Contains(book))
        {
            Books.Remove(book);
            Console.WriteLine($"Book {book.Title} deleted from library {Name}");
        }
        else
        {
            Console.WriteLine($"Book {book.Title} not found in library {Name}");
        }
    }
    
    public void DeleteMediaItem(MediaItem mediaItem)
    {
        if (MediaItems.Contains(mediaItem))
        {
            MediaItems.Remove(mediaItem);
            Console.WriteLine($"Media item {mediaItem.Title} deleted from library {Name}");
        }
        else
        {
            Console.WriteLine($"Media item {mediaItem.Title} not found in library {Name}");
        }
    }
    
    public void PrintCatalog()
    {
        Console.WriteLine($"Catalog of library {Name}");
        Console.WriteLine("Books:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Publisher year: {book.PublisherYear}");
        }
        Console.WriteLine("Media items:");
        foreach (var mediaItem in MediaItems)
        {
            Console.WriteLine($"Title: {mediaItem.Title}, Media type: {mediaItem.MediaType}, Duration: {mediaItem.Duration}");
        }
    }
}