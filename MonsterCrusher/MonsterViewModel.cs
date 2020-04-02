using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MonsterCrusher
{
    public class MonsterPropertyViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class MonsterViewModel
    {
        private Ref<SaveMonster> _save;
        private List<MonsterPropertyViewModel> _properties = new List<MonsterPropertyViewModel>();

        public MonsterViewModel(Ref<SaveMonster> save)
        {
            _save = save;

            SaveMonster monster = save.Value;

            _properties.Add(new MonsterPropertyViewModel() { Name = "name", Value = monster.name });
            _properties.Add(new MonsterPropertyViewModel() { Name = "race1", Value = monster.race1 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "race2", Value = monster.race2 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "inHeat", Value = monster.inHeat.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "firstTime", Value = monster.firstTime });
            _properties.Add(new MonsterPropertyViewModel() { Name = "staminaCurrent", Value = monster.staminaCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "staminaMaximum", Value = monster.staminaMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "mentalCurrent", Value = monster.mentalCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "mentalMaximum", Value = monster.mentalMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "pleasure", Value = monster.pleasure.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "shameCurrent", Value = monster.shameCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "shameMaximum", Value = monster.shameMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "prideCurrent", Value = monster.prideCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "prideMaximum", Value = monster.prideMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "levelObedience", Value = monster.levelObedience.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statObedience", Value = monster.statObedience.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "levelLewdness", Value = monster.levelLewdness.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statLewdness", Value = monster.statLewdness.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "levelTechnique", Value = monster.levelTechnique.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statTechnique", Value = monster.statTechnique.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "levelAffection", Value = monster.levelAffection.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statAffection", Value = monster.statAffection.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "prostitution", Value = monster.prostitutionCount.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "squeezedDry", Value = monster.squeezedDry.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "analTraining", Value = monster.analTraining.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "urineTraining", Value = monster.urineTraining.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "moneyEarned", Value = monster.moneyEarned.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "exchangePoints", Value = monster.exchangePoints.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "pricePurchase", Value = monster.pricePurchase.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "priceSale", Value = monster.priceSale.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageFace", Value = monster.imageFace });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageTatie", Value = monster.imageTatie });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageFaceMini1", Value = monster.imageFaceMini1 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageFaceMini2", Value = monster.imageFaceMini2 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageIcon", Value = monster.imageIcon });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown1", Value = monster.unknown1.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown2", Value = monster.unknown2.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown3", Value = monster.unknown3.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown5", Value = monster.unknown5.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown6", Value = monster.unknown6.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown7", Value = monster.unknown7.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown8", Value = monster.unknown8.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown12", Value = monster.unknown12.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown13", Value = monster.unknown13.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown14", Value = monster.unknown14.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown15", Value = monster.unknown15.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown16", Value = monster.unknown16.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown17", Value = monster.unknown17.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown18", Value = monster.unknown18.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown19", Value = monster.unknown19.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown21", Value = monster.unknown21.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown22", Value = monster.unknown22.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown23", Value = monster.unknown23.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown24", Value = monster.unknown24.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown25", Value = monster.unknown25.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown26", Value = monster.unknown26.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown28", Value = monster.unknown28.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown29", Value = monster.unknown29.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown30", Value = monster.unknown30.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "checksum1", Value = monster.checksum1.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "checksum2", Value = monster.checksum2.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "checksum3", Value = monster.checksum3.ToString() });
        }

        public override string ToString()
        {
            string result = _save.Value.name;
            if (IsUnused)
            {
                result += " [unused]";
            }
            return result;
        }

        public Ref<SaveMonster> Save
        {
            get { return _save; }
        }

        public bool IsUnused { get; set; }

        public string Name
        {
            get { return _save.Value.name; }
        }

        public List<MonsterPropertyViewModel> Properties
        {
            get { return _properties; }
            set
            {
                _properties = value;
            }
        }
    }
}
