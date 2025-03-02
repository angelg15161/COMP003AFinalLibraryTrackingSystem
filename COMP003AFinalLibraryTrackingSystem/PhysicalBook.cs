namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Physical Book derived class which is a type of Book. 
/// </summary>
internal class PhysicalBook : Book
{
    // fields (private)
    private int _pages;
    private string _genre; 

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
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Genre cannot be empty. ");
            }
            _genre = value;
        }
    }
}