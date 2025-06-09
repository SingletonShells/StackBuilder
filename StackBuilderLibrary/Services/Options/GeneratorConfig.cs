using System.Text.Json;
//using System.Text.Json.Serialization;

namespace StackBuilderLibrary.Services.Options;

public class GeneratorConfig
{
    private const string FILE_EXTENSION = ".json";

    private List<GeneratorHelper> configs = new List<GeneratorHelper>();
    public IEnumerable<GeneratorHelper> Configs => configs;

    public void addProjectConfig(string name, string directory, string template)
    {
        configs.Add(new GeneratorHelper(name, directory, template));
    }


    public IEnumerable<GeneratorHelper> getProjectConfigs()
    {
        return configs;
    }

    //    public GeneratorConfig(GeneratorHelper helper)
    //   {
    //        createConfig(helper.Name, helper);
    //    }

    public void createConfig(GeneratorHelper helper)
    {
        var file = helper.Directory + FILE_EXTENSION;
        //var file = Path.Combine(helper.Directory, FILE_EXTENSION);

        string jsonString = JsonSerializer.Serialize(helper);
        File.WriteAllText(file, jsonString);
    }


}
