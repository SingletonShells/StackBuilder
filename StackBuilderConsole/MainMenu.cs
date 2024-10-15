using System;

namespace StackBuilderConsole;

public static class MainMenu
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Stack Builder!");
        Console.WriteLine("1. Create a new stack");
        Console.WriteLine("2. View existing stacks");
        Console.WriteLine("3. Exit");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateStackMenu.show();
                break;
            case "2":
                CreateStackMenu.show();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadKey();
                Show();
                break;
        }
    }

}
