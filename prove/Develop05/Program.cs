using System;

class Program
{
    static void Main(string[] args)
    {
        // calls login function first to set the user and filehandler instances then loops through the menu select and menu runSelection methods until the exit option is selected.
        Console.Clear();
        Menu menu = new Menu();
        menu.login();
        while(true) {
            menu.select();
            menu.runSelection();
        }
    }
}