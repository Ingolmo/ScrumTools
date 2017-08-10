using FreshMvvm;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

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
        /* Private Methods */
        private void InitializeCommands()
        {
            _closeCommand = new Command(async () => await CloseExecute());
        }

        private async Task CloseExecute()
        {
            await CoreMethods.PopPageModel(true, true);
        }
    }
}
