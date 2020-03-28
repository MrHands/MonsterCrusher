using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    public sealed class AppSettings
    {
        private static readonly AppSettings _instance = new AppSettings();

        public string settingsPath = "";

        static AppSettings()
        {
        }

        private AppSettings()
        {
            string systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            settingsPath = Path.Combine(systemPath, "MonsterCrusher");
        }

        public static AppSettings Instance
        {
            get { return _instance; }
        }
    }
}
