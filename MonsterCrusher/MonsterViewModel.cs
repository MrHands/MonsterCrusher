using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MonsterCrusher
{
    public class MonsterPropertyViewModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class MonsterViewModel
    {
        private SaveMonster _save;
        private CollectionView _properties;

        public MonsterViewModel(SaveMonster save)
        {
            _save = save;

            List<MonsterPropertyViewModel> properties = new List<MonsterPropertyViewModel>();
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown1", Value = _save.unknown1.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "name", Value = _save.name });
            properties.Add(new MonsterPropertyViewModel() { Name = "race1", Value = _save.race1 });
            properties.Add(new MonsterPropertyViewModel() { Name = "race2", Value = _save.race2 });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown9", Value = _save.unknown9.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "staminaCurrent", Value = _save.staminaCurrent.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "staminaMaximum", Value = _save.staminaMaximum.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "mentalCurrent", Value = _save.mentalCurrent.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "mentalMaximum", Value = _save.mentalMaximum.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "pleasure", Value = _save.pleasure.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "shameCurrent", Value = _save.shameCurrent.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "shameMaximum", Value = _save.shameMaximum.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "prideCurrent", Value = _save.prideCurrent.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "prideMaximum", Value = _save.prideMaximum.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "prideMaximum", Value = _save.prideMaximum.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "statObedience", Value = _save.statObedience.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "statLewdness", Value = _save.statLewdness.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "statTechnique", Value = _save.statTechnique.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "statAffection", Value = _save.statAffection.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "prostitutionCount", Value = _save.prostitutionCount.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "moneyEarned", Value = _save.moneyEarned.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "squeezedDry", Value = _save.squeezedDry.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "pricePurchase", Value = _save.pricePurchase.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "priceSale", Value = _save.priceSale.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown12", Value = _save.unknown12.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown13", Value = _save.unknown13.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown14", Value = _save.unknown14.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown15", Value = _save.unknown15.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown16", Value = _save.unknown16.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown17", Value = _save.unknown17.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown18", Value = _save.unknown18.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown19", Value = _save.unknown19.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown21", Value = _save.unknown21.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown22", Value = _save.unknown22.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown23", Value = _save.unknown23.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown24", Value = _save.unknown24.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown25", Value = _save.unknown25.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown26", Value = _save.unknown26.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "unknown28", Value = _save.unknown28.ToString() });
            properties.Add(new MonsterPropertyViewModel() { Name = "imageFace", Value = _save.imageFace });
            properties.Add(new MonsterPropertyViewModel() { Name = "imageTatie", Value = _save.imageTatie });
            properties.Add(new MonsterPropertyViewModel() { Name = "imageFaceMini1", Value = _save.imageFaceMini1 });
            properties.Add(new MonsterPropertyViewModel() { Name = "imageFaceMini2", Value = _save.imageFaceMini2 });
            properties.Add(new MonsterPropertyViewModel() { Name = "imageIcon", Value = _save.imageIcon });

            _properties = new CollectionView(properties);
        }

        public override string ToString()
        {
            return _save.name;
        }

        public string Name
        {
            get { return _save.name; }
        }

        public CollectionView Properties
        {
            get { return _properties; }
        }
    }
}
