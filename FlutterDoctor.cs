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
            ProcessStartInfo psi = new ProcessStartInfo("flutter.bat");
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            psi.Arguments = "doctor";
            psi.WorkingDirectory = Path.Combine( flutterFolder, "flutter\\bin");
            Process.Start(psi);
        }
    }
}
