using System.Diagnostics;

namespace StackBuilderLibrary.Services.Angular;

public class AngularHelper
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

    public Process getProcess(string directory, string filename, string type)
    {
        Process process = new Process();
        process.StartInfo = getStartInfo();
        process.Start();

        process.StandardInput.WriteLine($"cd {directory}");
        process.StandardInput.WriteLine($"dotnet new {type} -o {filename}");
        process.StandardInput.WriteLine("exit");

        return process;
    }
}
