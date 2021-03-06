using CaliburnWPFApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Caliburn.Micro;
using CaliburnWPFApp.Library.Api;
using System.Threading.Tasks;
using CaliburnWPFApp.Library.Models;

namespace CaliburnWPFApp.ViewModels
{

    public class StatViewModel : Screen
    {
        private int lastIdIndex = 0;
        ICharacterStatEndpoint _statEndpoint;
        public StatViewModel(ICharacterStatEndpoint statEndpoint)
        {
            _statEndpoint = statEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadStats();
        }
        //https://www.youtube.com/watch?v=boDpqLwviQc&list=PLLWMQd6PeGY0bEMxObA6dtYXuJOGfxSPx&index=17 
        //How to work around constructors not allowing async. 1 hour mark
        private async Task LoadStats()
        {
            var statList = await _statEndpoint.GetAll();
            Stats = new BindingList<DisplayCharacterStatModel>();
        }
        private BindingList<DisplayCharacterStatModel> _stats;

        public BindingList<DisplayCharacterStatModel> Stats
        {
            get => _stats;
            set
            {
                _stats = value;
                NotifyOfPropertyChange(() => Stats);
            }
        }

        public DisplayCharacterStatModel SelectedStat 
        {
            get 
            { 
                return _selectedStat;
            }
            set
            {
                _selectedStat = value;
                NotifyOfPropertyChange(() => SelectedStat);
                NotifyOfPropertyChange(() => CanSetStatValues);
                NotifyOfPropertyChange(() => CanResetStat);
            }
        }

        private DisplayCharacterStatModel _selectedStat;
       
        public bool CanResetStat
        {
            get
            {
                bool output = false;
                if (SelectedStat != null)
                {
                    output = true;
                }

                return output;
            }
        }

        public bool CanSetStatValues
        {
            get
            {
                bool output = true;
                foreach (var item in Stats)
                {
                    if(SelectedStat.StatName.ToUpper() == item.StatName.ToUpper())
                    {
                        output = false;
                    }
                }

                return output;
            }
        }

        public void AddNewStat()
        {
            CheckLastIdIndex();
            DisplayCharacterStatModel newStat = new DisplayCharacterStatModel();
            Stats.Add(newStat);
            SelectedStat = newStat;

            Stats.ResetBindings();
        }

        public void ResetStagedStat()
        {
            SelectedStat.ResetModelValues();
            Stats.ResetBindings();
        }

        public async Task SetStatValues()
        {
            //Prep frontend Model for backend
            StagedCharacterStatModel model = new StagedCharacterStatModel(); 

            model.Id = SelectedStat.Id;
            model.StatName = SelectedStat.StatName;
            model.BaseValue = SelectedStat.BaseValue;
            model.GenericScale = SelectedStat.GenericScale;
            await _statEndpoint.PostStat(model);

            Stats.ResetBindings();
        }
        private int CheckLastIdIndex()
        {
            if(lastIdIndex > 0)
            {
                lastIdIndex++;
                return lastIdIndex; 
            }
            else
            {
                foreach (var item in Stats)
                {
                    if (item.Id > lastIdIndex)
                    {
                        lastIdIndex = item.Id;
                    }
                }
                lastIdIndex++;
                return lastIdIndex;
            }
        }
    }
}
