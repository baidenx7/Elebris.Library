using AutoMapper;
using Caliburn.Micro;
using CaliburnWPFApp.Library.Api;
using CaliburnWPFApp.Library.Models;
using CaliburnWPFApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnWPFApp.ViewModels
{

    public class StatViewModel : Screen
    {
        private int lastIdIndex = 0;
        ICharacterStatEndpoint _statEndpoint;
        IMapper _mapper;
        StatusInfoViewModel _status;
        IWindowManager _manager;
        public StatViewModel(ICharacterStatEndpoint statEndpoint, IMapper mapper, IWindowManager manager, StatusInfoViewModel status)
        {
            _statEndpoint = statEndpoint;
            _mapper = mapper;
            _manager = manager;
            _status = status;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);

            try
            {
                #region TestCode
                if (Stats == null || Stats.Count <= 0)
                {
                    Stats = new BindingList<DisplayCharacterStatModel>();
                    Stats.Add(new DisplayCharacterStatModel { Id = -1, StatName = "TestStat", BaseValue = 0, GenericScale = 0 });
                    //Trying to work out another kink, need to ensure this line is completely deletable in the future (as of 3/18/21)
                    //This is successfully overwritten by the few items in my database so the Original issue is a race condition
                }
                #endregion

                await LoadStats();
            }
            catch (Exception ex)
            {

                dynamic settings = new ExpandoObject();
                settings.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                settings.ResizeMode = ResizeMode.NoResize;
                settings.Title = "System Error";
                if (ex.Message == "Unauthorized")
                {
                    _status.UpdateMessage("Unauthorized Access", "You do not have sufficient permissions");
                    await _manager.ShowDialogAsync(_status, null, settings);
                }
                else
                {
                    _status.UpdateMessage("Fatal Exception", ex.Message);
                    await _manager.ShowDialogAsync(_status, null, settings);
                }
                await TryCloseAsync();
            }
        }
        //https://www.youtube.com/watch?v=boDpqLwviQc&list=PLLWMQd6PeGY0bEMxObA6dtYXuJOGfxSPx&index=17 
        //How to work around constructors not allowing async. 1 hour mark
        private async Task LoadStats()
        {
            var statList = await _statEndpoint.GetAll(); // get backend format from endpoint
            var stats = _mapper.Map<List<DisplayCharacterStatModel>>(statList); //map to desired format
            Stats = new BindingList<DisplayCharacterStatModel>(stats); // fill bindinglist with mapped stats



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
                    if (SelectedStat != null && SelectedStat.StatName.ToUpper() == item.StatName.ToUpper())
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
            if (lastIdIndex > 0)
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
