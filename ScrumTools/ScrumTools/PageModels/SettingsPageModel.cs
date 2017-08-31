using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System;
using ScrumTools.Helpers;

namespace ScrumTools.PageModels
{
    public class SettingsPageModel : FreshBasePageModel
    {
        private bool _gridOn;
        public bool GridOn
        {
            get { return _gridOn; }
            set { SetGridOn(value); }
        }

        private TimeSpan _defaultTimer;
        public TimeSpan DefaultTimer
        {
            get { return _defaultTimer; }
            set { SetDefaultTimer(value); }
        }

        public SettingsPageModel()
        {
            InitializeCommands();
            _gridOn = Settings.CardDisplay.Display.Equals(Settings.CardDisplay.Grid);
            _defaultTimer = Settings.Timer.Time;
        }

        /* Commands */

        /* Private Methods */
        private void InitializeCommands()
        {
            
        }

        private void SetGridOn(bool value)
        {
            _gridOn = value;
            RaisePropertyChanged("GridOn");

            if (value)
                Settings.CardDisplay.Display = Settings.CardDisplay.Grid;
            else
                Settings.CardDisplay.Display = Settings.CardDisplay.List;
        }

        private void SetDefaultTimer(TimeSpan value)
        {
            _defaultTimer = value;
            RaisePropertyChanged("DefaultTimer");

            Settings.Timer.Time = value;
        }
    }
}
