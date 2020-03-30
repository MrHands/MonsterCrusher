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

        public string Date
        {
            get
            {
                if (_save is null)
                {
                    return "2020-01-01";
                }
                else
                {
                    return String.Format("{0:D4}-{1:D2}-{2:D2} {3:D2}:{4:D2}",
                        _save.header.dateYear,
                        _save.header.dateMonth,
                        _save.header.dateDay,
                        _save.header.dateHour + 1,
                        _save.header.dateMinute);
                }
            }
        }
    }
}
