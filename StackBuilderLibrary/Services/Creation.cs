using System;
using System.Diagnostics;

namespace StackBuilderLibrary.Services;

public class Creation
{
    public void createAngular(string filename, string directory)
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

    public void createApi(string filename, string directory)
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
        process.StandardInput.WriteLine($"dotnet new webapi -o {filename}");
        process.StandardInput.WriteLine("exit");

        process.WaitForExit();
    }

    public void createWPF(string filename, string directory)
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
        process.StandardInput.WriteLine($"dotnet new wpf -o {filename}");
        process.StandardInput.WriteLine("exit");

        process.WaitForExit();
    }

    public void createClassLibrary(string filename, string directory)
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
        process.StandardInput.WriteLine($"dotnet new classlib -o {filename}");
        process.StandardInput.WriteLine("exit");

        process.WaitForExit();
    }

}
