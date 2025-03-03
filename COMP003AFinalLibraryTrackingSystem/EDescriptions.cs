namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Method overloading class for E-Book and Audio Book descriptions. 
/// </summary>
internal class EDescriptions
{
    // Overloaded methods 
    public static void EDescription(string bookType, string description)
    {
        Console.WriteLine(bookType + description);
    }
    public static void EDescription(string bookType, string description, string description2)
    {
        Console.WriteLine(bookType + description + description2);
    }
}