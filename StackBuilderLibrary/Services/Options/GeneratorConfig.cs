//using System;
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

    private void createConfig(string filename, GeneratorHelper helper)
    {
        var file = filename + FILE_EXTENSION;


        string jsonString = JsonSerializer.Serialize(helper);
        File.WriteAllText(file, jsonString);
    }


}
