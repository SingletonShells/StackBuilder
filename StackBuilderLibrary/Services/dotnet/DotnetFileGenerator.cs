//using System;
using System.Diagnostics;

namespace StackBuilderLibrary.Services.dotnet;

public class DotnetFileGenerator
{
    private readonly DotnetHelper _helper;
    private Process? process = null;

    private DotnetFileGenerator()
    {
        _helper = new DotnetHelper();
    }

    public void createApi(string filename, string directory)
    {
        process = _helper.getProcess(filename, directory);
        process.WaitForExit();
    }

    public void createWPF(string filename, string directory)
    {
        process = _helper.getProcess(filename, directory);
        process.WaitForExit();
    }

    public void createClassLibrary(string filename, string directory)
    {
        process = _helper.getProcess(filename, directory);
        process.WaitForExit();
    }
}
