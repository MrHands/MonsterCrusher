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
        private SaveMonster _save;

        public MonsterPropertyViewModel()
        {
        }
        public MonsterPropertyViewModel(SaveMonster save)
        {
            _save = save;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class MonsterViewModel
    {
        private SaveMonster _save;
        private List<MonsterPropertyViewModel> _properties = new List<MonsterPropertyViewModel>();

        public MonsterViewModel(SaveMonster save)
        {
            _save = save;

            _properties.Add(new MonsterPropertyViewModel() { Name = "name", Value = _save.name });
            _properties.Add(new MonsterPropertyViewModel() { Name = "race1", Value = _save.race1 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "race2", Value = _save.race2 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "firstTime", Value = _save.firstTime });
            _properties.Add(new MonsterPropertyViewModel() { Name = "staminaCurrent", Value = _save.staminaCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "staminaMaximum", Value = _save.staminaMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "mentalCurrent", Value = _save.mentalCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "mentalMaximum", Value = _save.mentalMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "pleasure", Value = _save.pleasure.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "shameCurrent", Value = _save.shameCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "shameMaximum", Value = _save.shameMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "prideCurrent", Value = _save.prideCurrent.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "prideMaximum", Value = _save.prideMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "prideMaximum", Value = _save.prideMaximum.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statObedience", Value = _save.statObedience.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statLewdness", Value = _save.statLewdness.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statTechnique", Value = _save.statTechnique.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "statAffection", Value = _save.statAffection.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "prostitution", Value = _save.prostitutionCount.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "squeezedDry", Value = _save.squeezedDry.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "analTraining", Value = _save.analTraining.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "urineTraining", Value = _save.urineTraining.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "moneyEarned", Value = _save.moneyEarned.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "exchangePoints", Value = _save.exchangePoints.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "pricePurchase", Value = _save.pricePurchase.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "priceSale", Value = _save.priceSale.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageFace", Value = _save.imageFace });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageTatie", Value = _save.imageTatie });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageFaceMini1", Value = _save.imageFaceMini1 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageFaceMini2", Value = _save.imageFaceMini2 });
            _properties.Add(new MonsterPropertyViewModel() { Name = "imageIcon", Value = _save.imageIcon });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown1", Value = _save.unknown1.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown2", Value = _save.unknown2.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown3", Value = _save.unknown3.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown5", Value = _save.unknown5.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown6", Value = _save.unknown6.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown7", Value = _save.unknown7.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown8", Value = _save.unknown8.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown9", Value = _save.unknown9.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown12", Value = _save.unknown12.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown13", Value = _save.unknown13.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown14", Value = _save.unknown14.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown15", Value = _save.unknown15.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown16", Value = _save.unknown16.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown17", Value = _save.unknown17.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown18", Value = _save.unknown18.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown19", Value = _save.unknown19.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown21", Value = _save.unknown21.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown22", Value = _save.unknown22.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown23", Value = _save.unknown23.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown24", Value = _save.unknown24.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown25", Value = _save.unknown25.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown26", Value = _save.unknown26.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown28", Value = _save.unknown28.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown29", Value = _save.unknown29.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "unknown30", Value = _save.unknown30.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "checksum1", Value = _save.checksum1.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "checksum2", Value = _save.checksum2.ToString() });
            _properties.Add(new MonsterPropertyViewModel() { Name = "checksum3", Value = _save.checksum3.ToString() });
        }

        public override string ToString()
        {
            string result = _save.name;
            if (IsUnused)
            {
                result += " [unused]";
            }
            return result;
        }

        public SaveMonster Save
        {
            get { return _save; }
        }

        public bool IsUnused { get; set; }

        public string Name
        {
            get { return _save.name; }
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
