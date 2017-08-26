using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System;

namespace ScrumTools.PageModels
{
    public class AboutPageModel : FreshBasePageModel
    {
        public AboutPageModel()
        {
            InitializeCommands();
        }
        /* Commands */
        private ICommand _closeCommand;
        public ICommand CloseCommand
        {
            get { return _closeCommand; }
        }

        private ICommand _goToGitHubCommand;
        public ICommand GoToGitHubCommand
        {
            get { return _goToGitHubCommand; }
        }

        private ICommand _goToTwitterCommand;
        public ICommand GoToTwitterCommand
        {
            get { return _goToTwitterCommand; }
        }

        private ICommand _goToLinkedinCommand;
        public ICommand GoToLinkedinCommand
        {
            get { return _goToLinkedinCommand; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _closeCommand = new Command(async () => await CloseExecute());
            _goToGitHubCommand = new Command(() => GoToGitHubExecute());
            _goToTwitterCommand = new Command(() => GoToTwitterExecute());
            _goToLinkedinCommand = new Command(() => GoToLinkedinExecute());
        }

        private void GoToGitHubExecute()
        {
            Device.OpenUri(new Uri("https://github.com/Ingolmo"));
        }

        private void GoToTwitterExecute()
        {
            Device.OpenUri(new Uri("https://twitter.com/JuanicoL"));
        }

        private void GoToLinkedinExecute()
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/in/juan-lópez-garcía-873551128"));
        }

        

        private async Task CloseExecute()
        {
            await CoreMethods.PopPageModel(true, true);
        }
    }
}
