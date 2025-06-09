using System;

namespace StackBuilderConsole;

public static class MainMenu
{
    public static string Show()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Stack Builder!");
        Console.WriteLine("1. Create a new stack");
        Console.WriteLine("2. View existing stacks");
        Console.WriteLine("3. Exit");

        var choice = 0;
        choice = Convert.ToInt32(Console.ReadLine());
        var outchoice = "";

        switch (choice)
        {
            case 1:
                outchoice = "Create";
                break;
            case 2:
                outchoice = "View";
                break;
            case 3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadKey();
                Show();
                break;
        }
        return outchoice;
    }

}
