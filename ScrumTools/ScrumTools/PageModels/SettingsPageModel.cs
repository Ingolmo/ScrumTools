using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ScrumTools.PageModels
{
    public class SettingsPageModel : FreshBasePageModel
    {
        public SettingsPageModel()
        {
            InitializeCommands();
        }

        /* Commands */
        private ICommand _goToAboutCommand;
        public ICommand GoToAboutCommand
        {
            get { return _goToAboutCommand; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _goToAboutCommand = new Command(async () => await GoToAboutExecute());
        }

        private async Task GoToAboutExecute()
        {
            await CoreMethods.PushPageModel<AboutPageModel>(null, true, true);
        }
    }
}
