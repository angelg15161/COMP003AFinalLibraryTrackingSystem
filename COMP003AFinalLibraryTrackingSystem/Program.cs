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
    }
}