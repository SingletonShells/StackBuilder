//using System;

namespace StackBuilderLibrary.Services.dotnet;

public class DotnetHub
{
    private readonly DotnetFileGenerator _dotnetManager = new DotnetFileGenerator();

    public void createApi(string filename, string directory) => _dotnetManager.createApi(filename, directory);
    public void createWPF(string filename, string directory) => _dotnetManager.createWPF(filename, directory);
    public void createClassLibrary(string filename, string directory) => _dotnetManager.createClassLibrary(filename, directory);
}
