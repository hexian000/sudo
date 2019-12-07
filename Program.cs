﻿using System.Diagnostics;

namespace sudo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmd = string.Join(" ", args);

            using (var process = new Process())
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C " + cmd,
                    UseShellExecute = true,
                    CreateNoWindow = true,
                    Verb = "runas",
                };
                process.StartInfo = startInfo;
                process.Start();
            }
        }
    }
}
