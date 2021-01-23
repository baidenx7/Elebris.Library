using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvxElebris.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxElebris.Core.ViewModels
{


    public class StatViewModel : MvxViewModel
    {
      
        public StatViewModel()
        {
            AddStatCommand = new MvxCommand(AddStat);
        }

        public IMvxCommand AddStatCommand { get; set; }
        public void AddStat()
        {
            StatModel s = new StatModel
            {
                StatName = StatName,
                GoverningAttribute = GoverningAttribute,
                BaseValue = BaseValue

            };

            StatName = string.Empty;
            GoverningAttribute = string.Empty;
            BaseValue = 0;
            Stats.Add(s);
        }

        public bool CanAddStat => StatName?.Length > 0;

        private MvxObservableCollection<StatModel> _stats = new MvxObservableCollection<StatModel>();

        public MvxObservableCollection<StatModel> Stats
        {
            get { return _stats; }
            set { SetProperty(ref _stats, value); } 
            //triggers INotifyPropertyChanged and typically only updates if the list is overriden (not just added to) 
            //circumvented by using an ObservableCollection
        }

        private string _statName;

        public string StatName

        {
            get { return _statName; }
            set 
            {
                SetProperty(ref _statName, value);
                RaisePropertyChanged(() => CanAddStat);
            }
        }
        private string _governingAttribute;

        public string GoverningAttribute

        {
            get { return _governingAttribute; }
            set { SetProperty(ref _governingAttribute, value); }
        }
        private float _baseValue;

        public float BaseValue

        {
            get { return _baseValue; }
            set { SetProperty(ref _baseValue, value); }
        }

    }
}

// in the example, RaisePropertyChanged(() => FullName); is used in the first/last name properties because it doesn't inherently get hooked into
//the Mvvm binding system so it needs a separate update call.

