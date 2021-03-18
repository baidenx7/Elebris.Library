using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CaliburnWPFApp.Models
{
    public class DisplayCharacterStatModel: INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string _statName;

        public string StatName
        {
            get { return _statName; }
            set {
                _statName = value;
                CallPropertyChanged(nameof(StatName));
            }
        }
        private float _baseValue;

        public float BaseValue
        {
            get { return _baseValue; }
            set {
                _baseValue = value;

                CallPropertyChanged(nameof(BaseValue));
            }
        }
        private float _genericScale;

        public float GenericScale
        {
            get { return _genericScale; }
            set {
                _genericScale = value;

                CallPropertyChanged(nameof(GenericScale));
            }
        }


        internal void ResetModelValues()
        {
            _baseValue = 0;
            _genericScale = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void CallPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
