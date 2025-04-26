using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEnvironmentManager
{
    public class AppSettings
    {
        public string FlutterSDKFolder { get; set; }

        [YamlDotNet.Serialization.YamlIgnore]
        public List<string> InstalledFlutterSDKs { get; set; } = new List<string>();


        [YamlDotNet.Serialization.YamlIgnore]
        public List<string> InstalledNPMSDKs { get; set; } = new List<string>();

        static AppSettings s_instance;
        public static AppSettings Instance => s_instance;

        static string FilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.yml");

        public static void Load()
        {
            if (!File.Exists(FilePath))
            {
                s_instance = new AppSettings();
                Instance.FlutterSDKFolder = "D:\\flutter";
                Instance.Save();
                return;
            }
            YamlDotNet.Serialization.Deserializer d = new YamlDotNet.Serialization.Deserializer();
            string yamlStr = File.ReadAllText(FilePath);
            s_instance = d.Deserialize<AppSettings>(yamlStr);
            Instance.ScanInstalledFlutterSDKs();
        }

        void ScanInstalledFlutterSDKs()
        {
            DirectoryInfo di = new DirectoryInfo(FlutterSDKFolder);
            if (!di.Exists) return;
            var dirs = di.GetDirectories("flutter*");
            foreach (var dir in dirs)
            {
                InstalledFlutterSDKs.Add(dir.FullName);
            }
            InstalledFlutterSDKs.Sort();
        }

        private void Save()
        {
            var s = new YamlDotNet.Serialization.Serializer();
            File.WriteAllText(FilePath, s.Serialize(this));
        }
    }
}
