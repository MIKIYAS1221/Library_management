namespace Library_management;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublisherYear { get; set; }
    
    public Book(string title, string author, string isbn, int publisherYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublisherYear = publisherYear;
    }
   
}