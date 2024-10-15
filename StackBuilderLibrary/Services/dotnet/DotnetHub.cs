//using System;

namespace StackBuilderLibrary.Services.dotnet;

public class DotnetHub
{
    private readonly DotnetFileGenerator _dotnetManager = new DotnetFileGenerator();

    public void createApi(string filename, string directory, string type) => _dotnetManager.createApi(filename, directory, type);
    public void createWPF(string filename, string directory, string type) => _dotnetManager.createWPF(filename, directory, type);
    public void createClassLibrary(string filename, string directory, string type) => _dotnetManager.createClassLibrary(filename, directory, type);
}
