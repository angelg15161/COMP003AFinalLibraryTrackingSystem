namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Class used to manage book information that user entered. 
/// </summary>
internal class BookInfo
{
    // Lists used to store book info 
    private List<PhysicalBook> _physicalBooks = new List<PhysicalBook>();
    private List<ComicBook> _comicBooks = new List<ComicBook>();
    private List<EBook> _eBooks = new List<EBook>();
    private List<AudioBook> _audioBooks = new List<AudioBook>();

    /// <summary>
    /// Method used as mini menu asking the user for book type to add. 
    /// </summary>
    /// <param name="bookType"></param>
    public void AddBook(string bookType)
    {
        Console.WriteLine("Select the book type (1-5): ");
        Console.WriteLine("1. Add a Physical Book \n2. Add a Comic Book \n3. Add an E-Book \n4. Add an Audio Book");
        Console.WriteLine("5. Cancel");
        string input = Console.ReadLine().Trim();

        try // Try-Catch for validation 
        {
            if (input == "1") // adds a physical book 
            {
                // Ask user to enter information for a Physical Book 
                Console.WriteLine("\nEnter the Physical Book's details:");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Publisher: ");
                string publisher = Console.ReadLine();
                Console.Write("Published Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Pages: ");
                int pages = int.Parse(Console.ReadLine());
                Console.Write("Genre: ");
                string genre = Console.ReadLine();
                
                // Add to Physical Books list 
                _physicalBooks.Add(new PhysicalBook(title, author, isbn, publisher, year, pages, genre));
                Console.WriteLine("The Physical Book has been successfully added! ");
            }
            else if (input == "2") // adds a comic book 
            {
                // Ask user to enter information for a Comic Book 
                Console.WriteLine("\nEnter the Comic Book's details:");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Publisher: ");
                string publisher = Console.ReadLine();
                Console.Write("Published Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Series: "); 
                string series = Console.ReadLine();
                
                // Add to Comic Books list 
                _comicBooks.Add(new ComicBook(title, author, isbn, publisher, year, series));
                Console.WriteLine("The Comic Book has been successfully added! ");
            }
            else if (input == "3") // adds an e book 
            {
                // Ask user to enter information for an E-Book 
                Console.WriteLine("\nEnter the Comic Book's details:");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Publisher: ");
                string publisher = Console.ReadLine();
                Console.Write("Published Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("File Format: ");
                string fileFormat = Console.ReadLine();
                Console.Write("File Size (MB): ");
                double fileSize = double.Parse(Console.ReadLine());

                // Add to E Books list 
                _eBooks.Add(new EBook(title, author, isbn, publisher, year, fileFormat, fileSize));
                Console.WriteLine("The E-Book has been successfully added! ");
            }
            else if (input == "4") // adds an audio book 
            {
                // Ask user to enter information for an Audio Book 
                Console.WriteLine("\nEnter the Comic Book's details:");
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Publisher: ");
                string publisher = Console.ReadLine();
                Console.Write("Published Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("File Format: ");
                string fileFormat = Console.ReadLine();
                Console.Write("File Size (MB): ");
                double fileSize = double.Parse(Console.ReadLine());
                Console.Write("Duration: ");
                string duration = Console.ReadLine();

                // Add to E Books list 
                _audioBooks.Add(new AudioBook(title, author, isbn, publisher, year, fileFormat, fileSize, duration));
                Console.WriteLine("The Audio Book has been successfully added! ");
            }
            else if (input == "5") // Cancels and sends back to main menu 
            {
                Console.WriteLine("Redirecting to Main Menu... ");
            }
            else // If user selected anything other than 1-5 they will be sent to main menu 
            {
                Console.WriteLine("Invalid input. Must be a number 1-5.\nRedirecting to Main Menu... ");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"{ex.Message} Try again.");
        }
        catch (Exception) 
        {
            Console.WriteLine("Invalid input. Try again.");  
        }
    }
}