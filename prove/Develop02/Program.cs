using System;
using System.IO;

class Program
{
    static void Main(string[] args) {
        bool exit = false;
        bool journalLoaded = false;
        Journal journal = new Journal("", "");
        Prompt prompts = loadPrompts();
        while (exit == false) {
            //Main menu
            int selection = mainMenu();

            //Option 1: Create new journal
            if (selection == 1) {
                createJournal();
            }

            //Option 2: Load journal
            if (selection == 2) {
                journal = loadJournal();
                journalLoaded = true;
            }

            //Option 3: Write entry
            if (selection == 3) {
                if (journalLoaded == true) {
                    Entry newEntry = writeEntry(prompts);
                    journal.addEntry(journal, newEntry);
                }
                else {
                    Console.WriteLine("\nError: No journal loaded.");
                }
            }

            //Option 4: View entries
            if (selection == 4) {
                if (journalLoaded == true) {
                    viewEntries(journal);
                }
                else {
                    Console.WriteLine("\nError: No journal loaded.");
                }
            }

            //Option 5: Save journal
            if (selection == 5) {
                if (journalLoaded == true) {
                    saveJournal(journal);
                }
                else {
                    Console.WriteLine("\nError: No journal loaded.");
                }
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
            Console.WriteLine("6. Exit\n");

            //Reads user input
            input = Console.ReadLine();

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

    static Prompt loadPrompts() {
        Prompt prompts = new Prompt();

        //Adds prompts
        prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        prompts._prompts.Add("What was the best part of my day?");
        prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts._prompts.Add("What fun or interesting facts did you find out today?");
        prompts._prompts.Add("What acts of service did you accomplish today?");
        prompts._prompts.Add("What did you spend the most time doing today? Was there anything else you wish you had spent more time on instead?");
        prompts._prompts.Add("What progress towards your personal goals did you accomplish today?");
        prompts._prompts.Add("What are you most proud of today?");
        
        return prompts;
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

        //Iterates through each line in the file after author and creates entries to add the journals list of entries
        foreach(string line in lines) {
            if(line != author) {
                Entry entry = new Entry("", "", "");
                string[] parts = line.Split("|");
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                journal._entries.Add(entry);
            }
        }    
        return journal;
        
    }
    static Entry writeEntry(Prompt prompts) {
        //Gives the user a random prompt
        string prompt = prompts.selectRandom();
        Console.WriteLine($"\n{prompt}");

        //Gets response from user
        string response = Console.ReadLine();

        //Gets current date
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        //Creates new Entry object to return
        Entry entry = new Entry(date, prompt, response);
        return entry;
    }
    static void viewEntries(Journal journal) {
        //Prints author
        Console.WriteLine($"\nAuthor: {journal._author}");

        //Iterates through entries and prints date, prompt, and response for each
        foreach (Entry entry in journal._entries) {
            Console.WriteLine($"\n{entry._date} {entry._prompt}\n{entry._response}");
        }
    }
    static void saveJournal(Journal journal) {
        //Clean all text from file
        File.WriteAllText(journal._fileName, journal._author);
        using (StreamWriter outputFile = new StreamWriter(journal._fileName))
        {
            //Write author to first line
            outputFile.WriteLine($"{journal._author}");

            //Write each entry to file with date on line 1, prompton line 2, and response on line 3
            foreach (Entry entry in journal._entries) {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }
}