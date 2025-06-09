namespace StackBuilderLibrary.Services.Options;

public class GeneratorHelper
{
    public string Name { get; set; } = string.Empty;
    public string Directory { get; set; }
    ProjectType ProjectType { get; set; }
    public string Type { get; private set; }

    public GeneratorHelper(string name, string directory, string projectType)
    {
        this.Name = name;
        this.Directory = directory;
        this.Type = projectType;

        ProjectType = projectType switch
        {
            "Angular" => new AngularProject(),
            "Api" => new ApiProject(),
            "WPF" => new WPFProject(),
            "ClassLibrary" => new ClassLibraryProject(),
            _ => throw new ArgumentException("Invalid project type")
        };
    }
}

abstract record ProjectType;

record AngularProject() : ProjectType;
record ApiProject() : ProjectType;
record WPFProject() : ProjectType;
record ClassLibraryProject() : ProjectType;
