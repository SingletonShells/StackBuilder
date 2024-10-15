using System;

namespace StackBuilderConsole;

public static class ExitMenu
{
    public static void Exit()
    {
        Console.Clear();
        Console.WriteLine("Exiting.........");
        Console.WriteLine("Are You Sure You Want To Exit: Y/n");
        Console.ReadKey();

        var choice = Console.ReadKey();

        if (choice.Key == ConsoleKey.Y)
        {
            Environment.Exit(0);
        }
        else if (choice.Key == ConsoleKey.N)
        {
            Console.Clear();
        }

    }

}
