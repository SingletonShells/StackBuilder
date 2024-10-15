namespace StackBuilderLibrary.Services.dotnet;

public enum projectTypes
{
    console,
    web,
    classlib,
    wpf,
    api
}

public class DotnetDataModel
{
    public string filename = string.Empty;
    public string directory = string.Empty;
    public string Types { get; set; }
    public List<string> projectTypes;

    public DotnetDataModel()
    {
        projectTypes = new List<string>();
    }

    public void addType(String type)
    {
        projectTypes.Add(Types);
    }
}
