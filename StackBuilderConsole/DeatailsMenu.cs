using StackBuilderLibrary.Services.Options;

namespace StackBuilderConsole;

public static class DetailsMenu
{
    public static GeneratorHelper Show(string type)
    {
        Console.Clear();
        Console.WriteLine("Enter Project Name");
        var name = Console.ReadLine() ?? "";
        Console.WriteLine("Enter Project Root Directory");
        var dir = Console.ReadLine() ?? "";
        Console.WriteLine("Enter Owner Name ");
        var owner = Console.ReadLine();

        GeneratorHelper _helper = new GeneratorHelper(name, dir, type);
        return _helper;
    }
}
