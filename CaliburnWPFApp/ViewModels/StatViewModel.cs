using CaliburnWPFApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Caliburn.Micro;
using CaliburnWPFApp.Library.Api;

namespace CaliburnWPFApp.ViewModels
{


    public class StatViewModel : Screen
    {
        ICharacterStatEndpoint _statEndpoint;
        public StatViewModel(ICharacterStatEndpoint statEndpoint)
        {
            _statEndpoint = statEndpoint;
            Stats = new BindingList<CharacterStatModel>(_statEndpoint.GetAll());
        }
        private BindingList<CharacterStatModel> _stats;

        public BindingList<CharacterStatModel> Stats
        {
            get => _stats;
            set
            {
                _stats = value;
                NotifyOfPropertyChange(() => Stats);
            }
        }
        //public void AddStat()
        //{
        //    StatModel s = new StatModel
        //    {
        //        StatName = StatName,
        //        GoverningAttribute = GoverningAttribute,
        //        BaseValue = BaseValue

        //    };

        //    StatName = string.Empty;
        //    GoverningAttribute = string.Empty;
        //    BaseValue = 0;
        //    Stats.Add(s);
        //}

        //public bool CanAddStat => StatName?.Length > 0;

        //private ObservableCollection<StatModel> _stats = new ObservableCollection<StatModel>();



        //private string _statName;

        //private string _governingAttribute;


        //private float _baseValue;



    }
}
