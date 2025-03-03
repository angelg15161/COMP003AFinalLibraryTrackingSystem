namespace COMP003AFinalLibraryTrackingSystem;

/// <summary>
/// Class used to manage book information that user entered. 
/// </summary>
internal class BookInfo
{
    // Lists used to store book info 
    private static List<PhysicalBook> _physicalBooks = new List<PhysicalBook>();
    private static List<ComicBook> _comicBooks = new List<ComicBook>();
    private static List<EBook> _eBooks = new List<EBook>();
    private static List<AudioBook> _audioBooks = new List<AudioBook>();

    /// <summary>
    /// Method used to add books with a mini menu asking the user for book type to add. 
    /// </summary>
    public static void AddBook()
    {
        Console.WriteLine("\nSelect the book type: ");
        Console.WriteLine("1. Add a Physical Book \n2. Add a Comic Book \n3. Add an E-Book \n4. Add an Audio Book");
        Console.WriteLine("5. Cancel");
        Console.Write("Enter your choice (1-5): ");
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
                Console.WriteLine("\nEnter the E-Book's details:");
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
                Console.WriteLine("\nEnter the Audio Book's details:");
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

    /// <summary>
    /// Method used to edit books with a mini menu asking the user for book type to edit.
    /// </summary>
    public static void EditBook()
    {
        Console.WriteLine("\nSelect the book type: ");
        Console.WriteLine("1. Edit a Physical Book \n2. Edit a Comic Book \n3. Edit an E-Book \n4. Edit an Audio Book");
        Console.WriteLine("5. Cancel");
        Console.Write("Enter your choice (1-5): ");
        string input = Console.ReadLine().Trim();

        try // Try-Catch for validation
        {
            if (input == "1") // edits a physical book
            {
                try
                {
                    if (_physicalBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no Physical Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_physicalBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the Physical Book you want to edit: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        PhysicalBook edit = _physicalBooks.Find(p => p.ISBN == isbn);
                            
                        // prompt the user to enter the new info for Physical Book 
                        Console.WriteLine("Enter the new details for the Physical Book: ");
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Publisher: ");
                        string publisher = Console.ReadLine();
                        Console.Write("Published Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Pages: ");
                        int pages = int.Parse(Console.ReadLine());
                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();
                        
                        // Update the book info
                        edit.Title = title;
                        edit.Author = author;
                        edit.Publisher = publisher;
                        edit.PublishedYear = year;
                        edit.Pages = pages;
                        edit.Genre = genre;
                        
                        Console.WriteLine("The Physical Book has been successfully edited! ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error editing the Physical Book.\nRedirecting to Main Menu...");
                }
            }
            else if (input == "2") // edits a comic book 
            {
                try
                {
                    if (_comicBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no Comic Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_comicBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the Comic Book you want to edit: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        ComicBook edit = _comicBooks.Find(p => p.ISBN == isbn);
                        
                        // prompt the user to enter the new info for Comic Book 
                        Console.WriteLine("Enter the new details for the Comic Book: ");
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Publisher: ");
                        string publisher = Console.ReadLine();
                        Console.Write("Published Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Series: ");
                        string series = Console.ReadLine();
                        
                        // Update the book info
                        edit.Title = title;
                        edit.Author = author;
                        edit.Publisher = publisher;
                        edit.PublishedYear = year;
                        edit.Series = series;
                        
                        Console.WriteLine("The Comic Book has been successfully edited! ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error editing the Comic Book.\nRedirecting to Main Menu...");
                }
            }
            else if (input == "3") // edits an e-book 
            {
                try
                {
                    if (_eBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no E-Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_eBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the E-Book you want to edit: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        EBook edit = _eBooks.Find(p => p.ISBN == isbn);
                        
                        // prompt the user to enter the new info for E-Book 
                        Console.WriteLine("Enter the new details for the E-Book: ");
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Publisher: ");
                        string publisher = Console.ReadLine();
                        Console.Write("Published Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("File Format: ");
                        string fileFormat = Console.ReadLine();
                        Console.Write("File Size (MB): ");
                        double fileSize = double.Parse(Console.ReadLine());
                        
                        // Update the book info
                        edit.Title = title;
                        edit.Author = author;
                        edit.Publisher = publisher;
                        edit.PublishedYear = year;
                        edit.FileFormat = fileFormat;
                        edit.FileSize = fileSize;
                        
                        Console.WriteLine("The E-Book has been successfully edited! ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error editing the E-Book.\nRedirecting to Main Menu...");
                }
            }
            else if (input == "4") // edits an audio book 
            {
                try
                {
                    if (_audioBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no Audio Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_audioBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the Audio Book you want to edit: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        AudioBook edit = _audioBooks.Find(p => p.ISBN == isbn);
                        
                        // prompt the user to enter the new info for the Audio Book 
                        Console.WriteLine("Enter the new details for the Audio Book: ");
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
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
                        
                        // Update the book info
                        edit.Title = title;
                        edit.Author = author;
                        edit.Publisher = publisher;
                        edit.PublishedYear = year;
                        edit.FileFormat = fileFormat;
                        edit.FileSize = fileSize;
                        edit.Duration = duration;
                        
                        Console.WriteLine("The Audio Book has been successfully edited! ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error editing the Audio Book.\nRedirecting to Main Menu...");
                }
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

    /// <summary>
    /// Method used to remove books with a mini menu asking the user for book type to remove.
    /// </summary>
    public static void RemoveBook()
    {
        Console.WriteLine("\nSelect the book type: ");
        Console.WriteLine("1. Remove a Physical Book \n2. Remove a Comic Book \n3. Remove an E-Book \n4. Remove an Audio Book");
        Console.WriteLine("5. Cancel");
        Console.Write("Enter your choice (1-5): ");
        string input = Console.ReadLine().Trim();

        try // Try-Catch for validation
        {
            if (input == "1") // removes a physical book
            {
                try
                {
                    if (_physicalBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no Physical Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_physicalBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the Physical Book you want to remove: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        PhysicalBook remove = _physicalBooks.Find(p => p.ISBN == isbn);

                        _physicalBooks.Remove(remove);
                        Console.WriteLine("Physical Book removed successfully.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error removing the Physical Book.\nRedirecting to Main Menu...");
                }
            }
            else if (input == "2") // removes a comic book 
            {
                try
                {
                    if (_comicBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no Comic Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_comicBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the Comic Book you want to remove: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        ComicBook remove = _comicBooks.Find(p => p.ISBN == isbn);

                        _comicBooks.Remove(remove);
                        Console.WriteLine("Comic Book removed successfully.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error removing the Comic Book.\nRedirecting to Main Menu...");
                }
            }
            else if (input == "3") // removes an e-book 
            {
                try
                {
                    if (_eBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no E-Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_eBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the E-Book you want to remove: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        EBook remove = _eBooks.Find(p => p.ISBN == isbn);

                        _eBooks.Remove(remove);
                        Console.WriteLine("E-Book removed successfully.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error removing the E-Book.\nRedirecting to Main Menu...");
                }
            }
            else if (input == "4") // removes an audio book 
            {
                try
                {
                    if (_audioBooks.Count == 0) //tells user if no books in the category 
                    {
                        Console.WriteLine("There are no Audio Books. \nRedirecting to Main Menu... ");
                    }
                    else if (_audioBooks.Count != 0)
                    {
                        Console.WriteLine("\nEnter the ISBN of the Audio Book you want to remove: ");
                        string isbn = Console.ReadLine();
                        
                        // search for the isbn 
                        AudioBook remove = _audioBooks.Find(p => p.ISBN == isbn);

                        _audioBooks.Remove(remove);
                        Console.WriteLine("Audio Book removed successfully.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error removing the Audio Book.\nRedirecting to Main Menu...");
                }
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

    /// <summary>
    /// Method used to view books.
    /// </summary>
    public static void ViewBooks()
    {
        try
        {
            foreach (var book in _physicalBooks)
            {
                Console.Write($"\n - {book.GetType().Name}: Title: {book.Title}");
                Console.Write($", Author: {book.Author}");
                Console.Write($", ISBN: {book.ISBN}");
                Console.Write($", Publisher: {book.Publisher}");
                Console.Write($", Published Year: {book.PublishedYear}");
                Console.Write($", Pages: {book.Pages}");
                Console.Write($", Genre: {book.Genre}");
            }
            foreach (var book in _comicBooks)
            {
                Console.Write($"\n - {book.GetType().Name}: Title: {book.Title}");
                Console.Write($", Author: {book.Author}");
                Console.Write($", ISBN: {book.ISBN}");
                Console.Write($", Publisher: {book.Publisher}");
                Console.Write($", Published Year: {book.PublishedYear}");
                Console.Write($", Series: {book.Series}");
            }
            foreach (var book in _eBooks)
            {
                Console.Write($"\n - {book.GetType().Name}: Title: {book.Title}");
                Console.Write($", Author: {book.Author}");
                Console.Write($", ISBN: {book.ISBN}");
                Console.Write($", Publisher: {book.Publisher}");
                Console.Write($", Published Year: {book.PublishedYear}");
                Console.Write($", File Format: {book.FileFormat}");
                Console.Write($", File Size: {book.FileSize} MB");
            }
            foreach (var book in _audioBooks)
            {
                Console.Write($"\n - {book.GetType().Name}: Title: {book.Title}");
                Console.Write($", Author: {book.Author}");
                Console.Write($", ISBN: {book.ISBN}");
                Console.Write($", Publisher: {book.Publisher}");
                Console.Write($", Published Year: {book.PublishedYear}");
                Console.Write($", File Format: {book.FileFormat}");
                Console.Write($", File Size: {book.FileSize} MB");
                Console.Write($", Duration: {book.Duration}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error displaying Books: {ex.Message}");
        }
    }
}