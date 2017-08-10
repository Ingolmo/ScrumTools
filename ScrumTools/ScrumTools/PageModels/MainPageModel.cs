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

        private ICommand _goToEvaluateCommand;
        public ICommand GoToEvaluateCommand
        {
            get { return _goToEvaluateCommand; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _goToSettingsCommand = new Command(async () => await GoToSettingsExecute());
            _goToEvaluateCommand = new Command(async () => await GoToEvaluateExecute());
        }

        private async Task GoToEvaluateExecute()
        {
            await CoreMethods.PushPageModel<SettingsPageModel>(null, true, true);
        }

        private async Task GoToSettingsExecute()
        {
            await CoreMethods.PushPageModel<SettingsPageModel>(null, false, true);
        }
    }
}
