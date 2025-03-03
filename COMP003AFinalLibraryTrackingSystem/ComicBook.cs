namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Comic Book derived class which is a type of Book.
/// </summary>
internal class ComicBook : Book
{
    // fields (private)
    private string _series;

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    /// <param name="isbn"></param>
    /// <param name="publisher"></param>
    /// <param name="year"></param>
    /// <param name="series"></param>
    public ComicBook(string title, string author, string isbn, string publisher, int year, string series)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Publisher = publisher;
        PublishedYear = year;
        Series = series;
    }

    // Constructor for override
    public ComicBook()
    {
        ;
    }
    
    // Properties (public) with implementation and validation
    public string Series
    {
        // implementation
        get { return _series; }
        set // validation ensuring that the Series' value is not empty
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Series cannot be empty. ");
            }
            _series = value;
        }
    }
    
    // Override GetDetails() from the Book abstract class
    public override void GetDetails()
    {
        Console.WriteLine("Comic Books include a Title, Author, ISBN, Publisher, Published year, Series ");
    }
}