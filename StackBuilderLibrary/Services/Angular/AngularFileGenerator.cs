using System;
using System.Diagnostics;

namespace StackBuilderLibrary.Services.Angular;

public class AngularFileGenerator
{
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
        process.StandardInput.WriteLine("exit");

        process.WaitForExit();
    }
}
