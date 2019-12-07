using System;
using System.Diagnostics;

namespace sudo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmd = string.Join(" ", args);
            var startInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                FileName = "cmd.exe",
                Arguments = "/C " + cmd,
                Verb = "runas",
            };
            using (var process = Process.Start(startInfo))
            {
                process.WaitForExit();
                Environment.Exit(process.ExitCode);
            }
        }
    }
}
