using CaliburnWPFApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Caliburn.Micro;
using CaliburnWPFApp.Library.Api;
using System.Threading.Tasks;

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
            Stats = new BindingList<CharacterStatModel>();
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

        public CharacterStatModel SelectedStat 
        {
            get 
            { 
                return _selectedStat;
            }
            set
            {
                _selectedStat = value;
                NotifyOfPropertyChange(() => SelectedStat);
                NotifyOfPropertyChange(() => UniqueStatStaged);
                NotifyOfPropertyChange(() => CanResetStat);
            }
        }

        private CharacterStatModel _selectedStat;
       
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

        public bool UniqueStatStaged
        {
            get
            {
                bool output = true;
                foreach (var item in Stats)
                {
                    if(SelectedStat.StatName == item.StatName)
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
            CharacterStatModel newStat = new CharacterStatModel();
            Stats.Add(newStat);
            SelectedStat = newStat;
        }

        public void ResetStagedStat()
        {
            SelectedStat.ResetModel();
            NotifyOfPropertyChange(() => SelectedStat);
            NotifyOfPropertyChange(() => UniqueStatStaged);
        }

        public void AlterExistingStatValues()
        {

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
