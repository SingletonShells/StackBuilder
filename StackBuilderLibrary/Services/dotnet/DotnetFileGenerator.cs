//using System;
using System.Diagnostics;

namespace StackBuilderLibrary.Services.dotnet;

public class DotnetFileGenerator
{
    private readonly DotnetHelper _helper;
    private Process? process = null;

    public DotnetFileGenerator()
    {
        _helper = new DotnetHelper();
    }

    public void createApi(string filename, string directory, string type)
    {
        process = _helper.getProcess(filename, directory, type);
        process.WaitForExit();
    }

    public void createWPF(string filename, string directory, string type)
    {
        process = _helper.getProcess(filename, directory, type);
        process.WaitForExit();
    }

    public void createClassLibrary(string filename, string directory, string type)
    {
        process = _helper.getProcess(filename, directory, type);
        process.WaitForExit();
    }
}
