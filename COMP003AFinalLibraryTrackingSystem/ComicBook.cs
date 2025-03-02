namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Comic Book derived class which is a type of Book.
/// </summary>
internal class ComicBook : Book
{
    // fields (private)
    private string _series;
    
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
        Console.WriteLine("Comic Books include a Title, Author, ISBN, Publisher, Published year, and Series. ");
    }
}