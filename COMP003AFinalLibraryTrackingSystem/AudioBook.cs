namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Audio Book derived class which is a type of Book.
/// </summary>
internal class AudioBook : Book
{
    // fields (private)
    private string _duration; 
    private string _fileFormat; 
    private double _fileSize;
    
    // Properties (public) with implementation and validation
    public string Duration
    {
        // implementation
        get { return _duration; }
        set // validation ensuring that the Duration's value is not empty
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Duration cannot be empty. ");
            }
        }
    }
    
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