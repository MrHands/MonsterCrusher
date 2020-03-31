using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCrusher
{
    public class MonsterViewModel
    {
        private SaveMonster _save;

        public MonsterViewModel(SaveMonster save)
        {
            _save = save;
        }

        public override string ToString()
        {
            return _save.name;
        }

        public string Name
        {
            get { return _save.name; }
        }
    }
}
