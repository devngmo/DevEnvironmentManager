using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEnvironmentManager
{
    internal class RegeditHelper
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr SendMessageTimeout(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam,
        uint fuFlags, uint uTimeout, out IntPtr lpdwResult);

        public static void SetFlutterPath(string path)
        {
            const string userEnvKey = @"Environment";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(userEnvKey, writable: true))
            {
                if (key == null)
                {
                    Console.WriteLine("Failed to open registry key.");
                    return;
                }

                string currentPath = key.GetValue("Path") as string ?? "";

                string newPathLC = path.Trim().ToLower();
                string[] allItems = currentPath.Split(';');
                bool replaced = false;
                for(int i = 0; i < allItems.Length; i++)
                {
                    string lc = allItems[i].Trim().ToLower();
                    if (lc.Contains("\\flutter"))
                    {
                        allItems[i] = path;
                        replaced = true;
                    }
                }
                string updatedPath = string.Join(";", allItems);
                if (!replaced)
                {
                    updatedPath += $";{path}";
                }

                key.SetValue("Path", updatedPath);
            }

            // Notify the system that the environment has changed
            SendMessageTimeout(new IntPtr(0xffff), 0x001A, IntPtr.Zero, "Environment", 0x0002, 100, out _);
        }


        
    }
}
