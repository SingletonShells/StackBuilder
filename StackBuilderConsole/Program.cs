using System.Linq;
using StackBuilderConsole;
using StackBuilderLibrary.Services.Angular;
using StackBuilderLibrary.Services.dotnet;
using StackBuilderLibrary.Services.Options;
using System.Threading;

string directory = Directory.GetCurrentDirectory();

GeneratorConfig _config = new GeneratorConfig();

var items = _config.getProjectConfigs();

var action = MainMenu.Show();
var choice = "";

switch (action)
{
    case "Create":
        choice = CreateStackMenu.show();
        break;
    case "View":
        break;
    default:
        Console.WriteLine("Invalid choice. Please try again.");
        Console.ReadKey();
        break;
}

var config = DetailsMenu.Show(choice);


_config.addProjectConfig(config.Name, config.Directory, config.Type);
var stuff = _config.getProjectConfigs();

stuff.Select(x => x).ToList().ForEach(x => Console.WriteLine(x.Name));
