namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// E-Book derived class which is a type of Book.
/// </summary>
internal class EBook : Book 
{
    // fields (private)
    private string _fileFormat; 
    private double _fileSize;
    
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