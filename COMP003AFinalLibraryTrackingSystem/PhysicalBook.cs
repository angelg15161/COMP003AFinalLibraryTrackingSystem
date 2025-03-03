namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Physical Book derived class which is a type of Book. 
/// </summary>
internal class PhysicalBook : Book
{
    // fields (private)
    private int _pages;
    private string _genre;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    /// <param name="isbn"></param>
    /// <param name="publisher"></param>
    /// <param name="year"></param>
    /// <param name="pages"></param>
    /// <param name="genre"></param>
    public PhysicalBook(string title, string author, string isbn, string publisher, int year, int pages, string genre)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Publisher = publisher;
        PublishedYear = year;
        Pages = pages;
        Genre = genre;
    }

    // Constructor for override
    public PhysicalBook()
    {
        ;
    }

    // Properties (public) with implementation and validation 
    public int Pages
    {
        // implementation
        get { return _pages; }
        set { _pages = value; }
    }

    public string Genre
    {
        // implementation
        get { return _genre; }
        set // validation ensuring that the Genre's value is not empty
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Genre cannot be empty. ");
            }
            _genre = value;
        }
    }

    // Override GetDetails() from the Book abstract class
    public override void GetDetails()
    {
        Console.WriteLine("\nPhysical Books include a Title, Author, ISBN, Publisher, Published year, Pages, Genre ");
    }
}