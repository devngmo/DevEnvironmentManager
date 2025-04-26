using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEnvironmentManager
{
    internal class FlutterDoctor
    {
        public static void Run(string flutterFolder)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.UseShellExecute = true;
            psi.CreateNoWindow = false;
            psi.Arguments = "/c flutter doctor";
            psi.WorkingDirectory = Path.Combine( flutterFolder, "flutter\\bin");
            var p = Process.Start(psi);
            p.WaitForExit();            
        }
    }
}
