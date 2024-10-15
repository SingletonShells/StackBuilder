using System.Diagnostics;

namespace StackBuilderLibrary.Services.dotnet;


public class DotnetHelper
{
    public ProcessStartInfo getStartInfo()
    {
        var startInfo = new ProcessStartInfo();
        startInfo.FileName = "cmd.exe";
        startInfo.RedirectStandardInput = true;
        startInfo.RedirectStandardOutput = true;
        startInfo.CreateNoWindow = true;
        startInfo.UseShellExecute = false;

        return startInfo;
    }

    public Process getProcess(string directory, string filename)
    {
        Process process = new Process();
        process.StartInfo = getStartInfo();
        process.Start();

        process.StandardInput.WriteLine($"cd {directory}");
        process.StandardInput.WriteLine($"dotnet new webapi -o {filename}");
        process.StandardInput.WriteLine("exit");

        return process;
    }
}
