namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Abstract class for all books. 
/// </summary>
internal abstract class Book
{
    // fields (private)
    private string _title;
    private string _author;
    private string _isbn;
    private string _publisher; 
    private int _publishedYear;
    
    // Properties (public) with implementation and validation 
    public string Title
    {
        // implementation 
        get { return _title; }
        set // validation ensuring that the Title's value is not empty 
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Title cannot be empty. ");
            }
            _title = value;
        }
    }

    public string Author
    {
        // implementation
        get { return _author; }
        set // validation ensuring that the Author's value is not empty
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Author cannot be empty. ");
            }
            _author = value;
        }
    }

    public string ISBN
    {
        // implementation
        get { return _isbn; }
        set // validation ensuring that the ISBN's value is not empty
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("ISBN cannot be empty. ");
            }
            _isbn = value;
        }
    }

    public string Publisher
    {
        // implementation
        get { return _publisher; }
        set // validation ensuring that the Publisher's value is not empty
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Publisher cannot be empty. ");
            }
            _publisher = value;
        }
    }

    public int PublishedYear
    {
        // implementation 
        get { return _publishedYear; }
        set { _publishedYear = value; }
    }
    
    // Empty abstract method 
    public abstract void GetDetails();
}