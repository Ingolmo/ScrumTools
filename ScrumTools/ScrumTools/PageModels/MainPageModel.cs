using FreshMvvm;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System;

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

        private ICommand _goToCardsGridCommand;
        public ICommand GoToCardsGridCommand
        {
            get { return _goToCardsGridCommand; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _goToSettingsCommand = new Command(async () => await GoToSettingsExecute());
            _goToAboutCommand = new Command(async () => await GoToAboutExecute());
            _goToCardsGridCommand = new Command(async () => await GoToCardsGridExecute());
        }

        private async Task GoToCardsGridExecute()
        {
            await CoreMethods.PushPageModel<CardsGridPageModel>(null, false, true);
        }

        private async Task GoToAboutExecute()
        {
            await CoreMethods.PushPageModel<AboutPageModel>(null, true, true);
        }

        private async Task GoToSettingsExecute()
        {
            await CoreMethods.PushPageModel<SettingsPageModel>(null, false, true);
        }
    }
}
