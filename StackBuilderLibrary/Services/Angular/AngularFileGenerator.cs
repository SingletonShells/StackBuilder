//using System;
using System.Diagnostics;

namespace StackBuilderLibrary.Services.Angular;

public class AngularFileGenerator
{
    private AngularHelper _helper = new AngularHelper();
    private ProcessStartInfo startInfo;

    public AngularFileGenerator()
    {
        startInfo = _helper.getStartInfo();
    }

    public void createProject(string filename, string directory)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "cmd.exe";
        startInfo.RedirectStandardInput = true;
        startInfo.RedirectStandardOutput = true;
        startInfo.CreateNoWindow = true;
        startInfo.UseShellExecute = false;

        Process process = new Process();
        process.StartInfo = startInfo;
        process.Start();

        process.StandardInput.WriteLine($"cd {directory}");
        process.StandardInput.WriteLine($"ng new {filename} --routing --style=scss");

        process.StandardInput.WriteLine($"cd {filename}");
        process.StandardInput.WriteLine($"npm install -f");

        process.StandardInput.WriteLine("exit");

        process.WaitForExit();
    }

    public void addDefaultLayout()
    {
        startInfo = _helper.getStartInfo();
    }

    public void addDefaultPage()
    {
        startInfo = _helper.getStartInfo();
    }
}
