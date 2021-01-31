using CaliburnWPFApp.Models;
using MvvmCross.Commands;
using MvvmCross.Navigation;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CaliburnWPFApp.ViewModels
{


    public class StatViewModel
    {

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

        public bool CanAddStat => StatName?.Length > 0;

        private ObservableCollection<StatModel> _stats = new ObservableCollection<StatModel>();

     

        private string _statName;

        private string _governingAttribute;

       
        private float _baseValue;

        

    }
}

// in the example, RaisePropertyChanged(() => FullName); is used in the first/last name properties because it doesn't inherently get hooked into
//the Mvvm binding system so it needs a separate update call.

