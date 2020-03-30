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
        private Save _save = null;

        public MainViewModel()
        {
        }
        public MainViewModel(Save save)
        {
            _save = save;
        }

        public String SettingsPath
        {
            get { return Properties.Settings.Default.GameDirectory; }
        }

        public UInt32 Days
        {
            get { return _save is null ? 0 : _save.header.days; }
        }

        public UInt32 Money
        {
            get { return _save is null ? 0 : _save.header.money; }
        }
    }
}
