namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// E-Book derived class which is a type of Book.
/// </summary>
internal class EBook : Book 
{
    // fields (private)
    private string _fileFormat; 
    private double _fileSize;

    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    /// <param name="isbn"></param>
    /// <param name="publisher"></param>
    /// <param name="year"></param>
    /// <param name="fileFormat"></param>
    /// <param name="fileSize"></param>
    public EBook(string title, string author, string isbn, string publisher, int year, string fileFormat, double fileSize)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Publisher = publisher;
        PublishedYear = year;
        FileFormat = fileFormat;
        FileSize = fileSize;
    }

    // Properties (public) with implementation and validation
    public string FileFormat
    {
        // implementation
        get { return _fileFormat; }
        set // validation ensuring that the File Format's value is not empty
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("File Format cannot be empty. ");
            }
            _fileFormat = value;
        }
    }

    public double FileSize
    {
        // implementation
        get { return _fileSize; }
        set { _fileSize = value; }
    }
    
    // Empty override GetDetails() from the Book abstract class
    public override void GetDetails()
    {
        ;
    }
}