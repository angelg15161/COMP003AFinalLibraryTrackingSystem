/*
    Author: Angel Gomez
    Course: COMP-003A
    Faculty: Jonathan Cruz
    Purpose: To serve as a library’s book tracking system.
*/
namespace COMP003AFinalLibraryTrackingSystem;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message 
        Console.WriteLine("Welcome to the library's book tracker! ");
        bool pass = true;
        
        while (pass)
        {
            string libraryPassword = "Password123"; // Preset library password 
            
            // Prompt the user to enter librarian password 
            Console.Write("\nPlease enter the Librarian's Password: ");
            string password = Console.ReadLine().Trim();

            if (password == libraryPassword)
            {
                Console.WriteLine("Password accepted! ");
                pass = false;
            }
            else 
            {
                Console.WriteLine("Incorrect Librarian Password, Try Again. ");
            }
        }

        bool exit = true; 
        while (exit) // Menu loop
        {
            Console.WriteLine("\n\nMain Menu: \n1. Add a Book \n2. Edit a Book \n3. Remove a Book \n4. View Books");
            Console.WriteLine("5. Book Type Descriptions \n6. Exit");
            Console.Write("Enter your choice (1-6): ");
            
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    BookInfo.AddBook();
                }
                else if (choice == 2)
                {
                    BookInfo.EditBook();
                }
                else if (choice == 3)
                {
                    BookInfo.RemoveBook();
                }
                else if (choice == 4)
                {
                    BookInfo.ViewBooks();
                }
                else if (choice == 5)
                {
                    Book PhysicalBook = new PhysicalBook();
                    Book ComicBook = new ComicBook();
                    
                    PhysicalBook.GetDetails();
                    ComicBook.GetDetails();
                    
                    string description = " include a Title, Author, ISBN, Publisher, Published year, File Format, File Size";
                    string description2 = ", Duration ";
                    string bookType1 = "E-Books";
                    string bookType2 = "Audio Books";
                    
                    EDescriptions.EDescription(bookType1, description);
                    EDescriptions.EDescription(bookType2, description, description2);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("\nGoodbye!");
                    exit = false;
                }
                else // Prompts user to select number 1-4 if another number was selected
                {
                    Console.WriteLine("Invalid input. Please select a number 1-4."); 
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Try again."); 
            }
        }
    }
}