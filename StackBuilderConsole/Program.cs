using System.Linq;
using StackBuilderConsole;
using StackBuilderLibrary.Services.Angular;
using StackBuilderLibrary.Services.dotnet;
using StackBuilderLibrary.Services.Options;

string directory = Directory.GetCurrentDirectory();

GeneratorConfig _config =  new GeneratorConfig();

_config.addProjectConfig("Nkateko", directory, "Angular");

var items = _config.getProjectConfigs();

foreach (var item in items)
{
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Directory);
}