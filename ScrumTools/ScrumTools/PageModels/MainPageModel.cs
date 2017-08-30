using FreshMvvm;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using ScrumTools.Helpers;

namespace ScrumTools.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {
            InitializeCommands();
        }

        /* Commands */
        private ICommand _goToSettingsCommand;
        public ICommand GoToSettingsCommand
        {
            get { return _goToSettingsCommand; }
        }

        private ICommand _goToAboutCommand;
        public ICommand GoToAboutCommand
        {
            get { return _goToAboutCommand; }
        }

        private ICommand _goToEstimateCommand;
        public ICommand GoToEstimateCommand
        {
            get { return _goToEstimateCommand; }
        }

        private ICommand _goToComingSoonCommand;
        public ICommand GoToComingSoonCommand
        {
            get { return _goToComingSoonCommand; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _goToSettingsCommand = new Command(async () => await GoToSettingsExecute());
            _goToAboutCommand = new Command(async () => await GoToAboutExecute());
            _goToEstimateCommand = new Command(async () => await GoToEstimateExecute());
            _goToComingSoonCommand = new Command(async () => await GoToComingSoonExecute());
        }

        private async Task GoToEstimateExecute()
        {
            if (Settings.CardDisplay.Display.Equals(Settings.CardDisplay.Grid))
                await CoreMethods.PushPageModel<CardsGridPageModel>(null, false, true);
            else
                await CoreMethods.PushPageModel<CardsListPageModel>(null, false, true);
        }

        private async Task GoToAboutExecute()
        {
            await CoreMethods.PushPageModel<AboutPageModel>(null, true, true);
        }

        private async Task GoToSettingsExecute()
        {
            await CoreMethods.PushPageModel<SettingsPageModel>(null, false, true);
        }

        private async Task GoToComingSoonExecute()
        {
            await CoreMethods.PushPageModel<TimerPageModel>(null, true, true);
        }
    }
}
