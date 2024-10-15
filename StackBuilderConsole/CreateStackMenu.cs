using System;
using System.Collections;

namespace StackBuilderConsole;

public static class CreateStackMenu
{
    public static void show()
    {
        Console.Clear();
        Console.WriteLine("Create Stack Menu");
        Console.WriteLine("Choose files to be created!");
        Console.WriteLine("1. Console Application");
        Console.WriteLine("2. Class Library");
        Console.WriteLine("3. Wpf Project");
        Console.WriteLine("4. Go Back");
        Console.WriteLine("5. Exit");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Console Application");
                break;
            case "2":
                Console.WriteLine("Class Library");
                break;
            case "3":
                Console.WriteLine("Wpf Project");
                break;
            case "4":
                MainMenu.Show();
                break;
            case "5":
                Console.WriteLine("Exiting...");
                ExitMenu.Exit();
                break;
            default:
                Console.WriteLine("Invalid choice");
                show();
                break;
        }
    }

}
