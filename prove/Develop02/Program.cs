using System;
using System.IO;

class Program
{
    static void Main(string[] args) {
        bool exit = false;
        while (exit == false) {
            //Main menu
            int selection = mainMenu();

            //Option 1: Create new journal
            if (selection == 1) {
                createJournal();
            }

            //Option 2: Load journal
            if (selection == 2) {
                loadJournal();
            }

            //Option 6: Exit program
            if (selection == 6) {
                exit = true;
            }
        }
    }
    static int mainMenu(){
        //Displays the main menu through the console and returns an int for user selection
        List<string> options = new List<string>() {"1", "2", "3", "4", "5", "6"};
        bool selection = false;
        string input = "";
        while (selection == false){
            //Displays options to user
            Console.WriteLine("\nSelect one of the following:");
            Console.WriteLine("1. Create new journal");
            Console.WriteLine("2. Load journal");
            Console.WriteLine("3. Write entry");
            Console.WriteLine("4. View entries");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            //Reads user input
            input = Console.ReadLine();
            Console.WriteLine();

            //Determines if input is valid
            if (options.Contains(input)) {
                //If input is valid, returns input
                selection = true;
            }
            else {
                //Gives a warning, then restarts the menu
                Console.WriteLine("Enter a valid input.");
            }
            }
        return int.Parse(input);
    }
    static void createJournal() {
        //Get variables for new Journal from user
        Console.Write("\nWhat is the filename? (must end with .txt extension): ");
        string fileName = Console.ReadLine();
        Console.Write("\nWho is the author?: ");
        string author = Console.ReadLine();

        //Creates new Journal and file
        Journal newJournal = new Journal(author, fileName);
        newJournal.createFile(newJournal);
    }
    static Journal loadJournal() {
        //Gets file name from user
        Console.Write("\nWhat is the file name?: ");
        string fileName = Console.ReadLine();
        //Creates and fills Journal object from txt file
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string author = lines[0];
        Journal journal = new Journal(author, fileName);
        return journal;
    }
}