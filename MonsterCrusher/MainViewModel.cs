﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MonsterCrusher
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Save _save = null;
        private string _monsterSelectedName = "";
        private MonsterViewModel _monsterSelected = null;
        private readonly CollectionView _monstersForSale = null;
        private readonly CollectionView _monstersOwned = null;

        public MainViewModel()
        {
        }
        public MainViewModel(ref Save save)
        {
            _save = save;

            List<MonsterViewModel> forSaleVMs = new List<MonsterViewModel>();
            foreach (var m in _save.monstersSale)
            {
                MonsterViewModel vm = new MonsterViewModel(m);
                forSaleVMs.Add(vm);
            }
            _monstersForSale = new CollectionView(forSaleVMs);

            List<MonsterViewModel> ownedVMs = new List<MonsterViewModel>();

            foreach (var m in _save.monstersOwned)
            {
                MonsterViewModel vm = new MonsterViewModel(m) { IsUnused = ownedVMs.Count >= _save.header.monsterCount };
                ownedVMs.Add(vm);
            }

            _monstersOwned = new CollectionView(ownedVMs);
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

        public string MonsterSelectedName
        {
            get { return _monsterSelectedName; }
            set
            {
                if (_monsterSelectedName != value)
                {
                    _monsterSelected = new MonsterViewModel(_save.monstersOwned.Find(monster => monster.Value.name == value));

                    _monsterSelectedName = value;
                    OnPropertyChanged("MonsterSelected");
                }
            }
        }

        public MonsterViewModel MonsterSelected
        {
            get { return _monsterSelected; }
        }

        public CollectionView MonstersForSale
        {
            get { return _monstersForSale; }
        }

        public CollectionView MonstersOwned
        {
            get { return _monstersOwned; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
