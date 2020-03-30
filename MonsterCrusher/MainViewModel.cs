using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    public class MainViewModel
    {
        public String SettingsPath
        {
            get { return Properties.Settings.Default.GameDirectory; }
        }
    }
}
